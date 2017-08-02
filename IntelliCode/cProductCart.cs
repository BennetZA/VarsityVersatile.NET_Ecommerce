using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntelliCode
{
    public class cProductCart
    {

        ////////////////////////////////////////////////////////////////////////
        //ID of the product
        private int _ID;
        //Product name
        private string _Prodname;
        //product description
        private string _ProdDescription;
        //product specifier
        private bool _Instock;
        //product price
        private double _Price;
        //product quantity
        private int _Quantity;
        //product extra description
        private string _ExtraDescription;
        //product total
        private double _Total;


        private string _ImagePath;
        /////////////////////////////////////////////////
        //Property methods to set the instance variables
        public double Total
        {

            //returns the total price in the shopping cart
            get { return Totalprice(); }
        }

        ///////////////////////////////////////////////////////////
        //Assigns the image to the cart for the user to see
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }


        //////////////////////////////////////////////////
        //constructor
        //sets the id of the product
        public cProductCart(int ID)
        {
            _ID = ID;
        }
        //////////////////////////////////////////////////

        public double Totalprice()
        {
            //returns the total price of the products in the shopping cart
            return _Price * _Quantity;
        }
        /////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////
        //property method for the ID
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        //////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////
        //Property method for the name
        public string ProdName
        {
            get { return _Prodname; }
            set { _Prodname = value; }
        }
        ////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////
        //property method for the product description
        public string ProdDescription
        {
            get { return _ProdDescription; }
            set { _ProdDescription = value; }
        }
        ///////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////
        //proprty method the instock products
        public bool Instock
        {
            get { return _Instock; }
            set { _Instock = value; }
        }

        /////////////////////////////////////////////////////////////
        //property methods for the product price
        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        //////////////////////////////////////////////////////////////
        //property methods for the product quantity
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        ///////////////////////////////////////////////////////////////
        //property method for the product extra description
        public string ExtraDescription
        {
            get { return _ExtraDescription; }
            set { _ExtraDescription = value; }
        }
    }
}