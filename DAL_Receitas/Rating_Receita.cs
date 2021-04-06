using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL_Receitas
{
    class Rating_Receita
    {
        private Rating _rating;
        private int _userID;
        private Receita _receita;

        public int UserID { get => _userID; set => _userID = value; }
        public Receita Receita { get => _receita; set => _receita = value; }
        internal Rating Rating { get => _rating; set => _rating = value; }

        public Rating_Receita()
        {
        }

        public Rating_Receita(int userID, Receita receita, Rating rating)
        {
            UserID = userID;
            UserID = userID;
            Receita = receita;
            Rating = rating;
        }
    }
}
