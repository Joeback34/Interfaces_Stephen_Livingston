using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Stephen_Livingston
{   
    /// <summary>
    /// Creates interface call IGenre and creates atuomattic properties for ESRB, Genre, and Title.
    /// </summary>
    interface IGenre
    {
        public string ESRB { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Describe(); // creates a method called describe.

    }
}
