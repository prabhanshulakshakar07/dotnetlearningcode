namespace Demo15_NotePad
{
    internal class Program
    {
        static void Main(string[] args)
        {





            #region demo 01:
            //Notepad notepad = new Notepad();
            //notepad.Copy();
            //notepad.DoSpellCheck(); 








            #endregion

            Notepad notepad = new Notepad(null);
            notepad.DoSpellCheck();

            SpellCheckerFactory spellCheckerFactory = new SpellCheckerFactory();
            ISpellcheker somecheker = spellCheckerFactory.GetSomeSpellCheker("gr");
            Notepad notepad1 = new Notepad(somecheker);
            notepad1.DoSpellCheck();

            HindiSpellChecker hindi = new HindiSpellChecker();
            KlingonSpellChecker klingon = new KlingonSpellChecker();

            Notepad notepad2 = new Notepad(hindi);
            notepad2.DoSpellCheck();
            Notepad notepad3 = new Notepad(klingon);
            notepad3.DoSpellCheck();


            //Notepad notepad2 = new Notepad("sp");
            //notepad2.DoSpellCheck();

            //Notepad notepad3 = new Notepad("gr");
            //notepad3.DoSpellCheck();


















        }
    }

    public class Notepad
    {
        SpellCheckerFactory spellCheckerFactory = new SpellCheckerFactory();
        private ISpellcheker _spellChecker = null;
        // Ctor level Dependency Injection Pattern
        // Open/Closed Principle : Open for extension , but closed for modification
       
        
        
        
        
        public Notepad(ISpellcheker checker)
        {
            if (checker == null)
            {
                _spellChecker = new EnglishSpellChecker();
            }
            else
            {
                _spellChecker = checker;
            }
        }
        #region lang depenedent

        //public Notepad(string lang)
        //{
        //    if (lang == null)
        //    {
        //        _spellChecker = new EnglishSpellChecker();
        //    }
        //    else
        //    {
        //        _spellChecker = spellCheckerFactory.GetSomeSpellCheker(lang);
        //    }
        //} 
        #endregion
        public void Cut()
        {
            // code
        }
        public void Copy()
        {
            // code
        }
        public void Paste()
        {
            // code
        }
        public void DoSpellCheck()
        {
            _spellChecker.SpellCheck();
        }

    }
    public interface ISpellcheker
    {
        void SpellCheck();
    }
    public class SpellCheckerFactory
    {
        public ISpellcheker GetSomeSpellCheker(string lang)
        {
            ISpellcheker spellcheker = null;
            switch (lang)
            {
                case "en":
                    spellcheker = new EnglishSpellChecker();
                    break;
                case "sp":
                    spellcheker = new SpanishSpellChecker();
                    break;
                case "gr":
                    spellcheker = new GermanSpellChecker();
                    break;
                default:
                    spellcheker = null;
                    break;
            }
            return spellcheker;
        }
    }
    public class EnglishSpellChecker : ISpellcheker
    {
        public void SpellCheck()
        {
            Console.WriteLine("Spell Check done for English Language");
        }
    }

    public class SpanishSpellChecker : ISpellcheker
    {
        public void SpellCheck()
        {
            Console.WriteLine("Spell Check done for Spanish Language");
        }
    }
    public class GermanSpellChecker : ISpellcheker
    {
        public void SpellCheck()
        {
            Console.WriteLine("Spell Check done for German Language");
        }
    }

    public class KlingonSpellChecker : ISpellcheker
    {
        public void SpellCheck()
        {
            Console.WriteLine("Spell Check done for Klingon Language");
        }
    }
    public class HindiSpellChecker : ISpellcheker
    {
        public void SpellCheck()
        {
            Console.WriteLine("Spell Check done for Hindi Language");
        }
    }








}
