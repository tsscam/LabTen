using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class MovieCls
    {
        private string movieTitle;
        private string category;

        public string Movie1
        {
            get
            {
                return movieTitle;
            }

            set
            {
                movieTitle = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public MovieCls()
        {
            //first constructor
            category = "";

            movieTitle = "";


        }

        public MovieCls(string TitleInput, string CategoryInput)
        {
            //second constructor
            category = CategoryInput;

            movieTitle = TitleInput; 

        }
       
        
    }
}
