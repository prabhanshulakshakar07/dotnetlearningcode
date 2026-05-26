using Microsoft.AspNetCore.Mvc;

namespace DisplayDataUsingActionMethod.Models
{
    // MVVM - Model - Vie - ViewModel- Controller
    public class ViewModel
    {
        // When we need to pass multiple collections of different buissness Entities to the View via Action methods, we genrate ViewModel CLasses which holds those entity collections as properties.
        // so we do not use ArrayList type non-generic collections to generate this kind of UI
        public List<Emp> es { get; set; }
        public List<Customer> cs { get; set; }
    }
}
