using System;
using System.Collections.Generic;

class Product:EHandel
{
    public int ProductId { get; set; }

    //int _productId;


    //public void SetProductId(int value)
    //{
    //    _productId = value;
    //}

    //public int GetProductId()

    //{

    //    return _productId;

    //}

}
class EHandel
{
    private bool _skicka = false;

    public void SetSkicka(bool value)
    {
        _skicka =value;

    }

    public bool GetSkicka()
    {
        return _skicka;

    }

    public string SkickaMail()
    {
        return "the mail is sent";

    }


}


namespace ClasserOs
{

    class Book : Product
    {
        //private string _isbn;
        //private string _author;
        private int _antalSidor;
        private int _vikt;
        private string _recension;

        //public void SetIsbn(string value)
        //{

        //    _isbn = value;

        //}

        ////public string GetIsbn()
        ////{
        ////    return _isbn;

        ////}
        public string Isbn { get; set; }

        //public void SetAuthor(string value)
        //{
        //    _author = value;
        //}

        //public string GetAuthor()
        //{
        //    return _author;
        //}
        public string Author{get;set;}


        public void SetAntalSidor(int value)
        {
            _antalSidor = value;
        }

        public int GetAntalSidor()
        {
            return _antalSidor;
        }

        public void SetVikt(int _antalSidor)
        {
            _vikt = _antalSidor*2;
        }

        public int GetVikt()
        {
            return _vikt;
        }

        public void SetRecension(int sidor)
        {
            if (sidor > 100)
                _recension = "bad";
            else
                _recension = "good";

        }

        public string GetRecension()
        {
            return _recension;
        }

        public void SetControllSidor()
        {
            if (_antalSidor > 1000)
                SetAntalSidor(400);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var b1 = new Book();

            var b2 = new Book();

            var list = new List<Book>();


            //b1.SetIsbn("XXXXXX");
            //string resultat = b1.GetIsbn();
            b1.Isbn = "1234";
            string isbn = b1.Isbn;


            //b1.SetAuthor("Jens");
            //string resultat2 = b1.GetAuthor();
            b1.Author = "Jens";
            string author = b1.Author;


            b1.SetAntalSidor(6000);

            b1.SetControllSidor();

            int sidor = b1.GetAntalSidor();



            b1.SetVikt(sidor);
            int vikt = b1.GetVikt();

            b1.SetRecension(sidor);
            string recension = b1.GetRecension();


            b1.ProductId = 1234;
            int productId = b1.ProductId;


            b1.SetSkicka(true);

            if (b1.GetSkicka())
            {
                string skicka = b1.SkickaMail();
            }

            Console.WriteLine($"Info om boken: \n*ISBN numret för b1 är {isbn}\n*författare för b1 är {author}\n*antal sidor: {sidor} \n*vikten är: {vikt}\n*boken var {recension}\n*produkt ID är: {productId}\n*");

        

        }
    }
}
