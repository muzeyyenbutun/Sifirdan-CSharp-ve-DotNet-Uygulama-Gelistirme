namespace CokBicimlilik
{
    class Kalem
    {
        public int MurekkepMiktari;
        public int Kapasite;
        public Kalem()
        {
            Kapasite = 100;
            MurekkepMiktari = Kapasite;
        }
        public virtual void Yaz(string yazi)
        {
            if (yazi.Length > MurekkepMiktari)
            {
                MurekkepMiktari = 0;
            }
            else
            {
                MurekkepMiktari -= yazi.Length;
            }
        }
    }
    class DolmaKalem : Kalem
    {
        public DolmaKalem()
        {
            MurekkepMiktari = 100;
        }
        public void Doldur()
        {
            MurekkepMiktari = Kapasite;
        }
        public override void Yaz(string yazi)
        {
            if (yazi.Length * 2 > MurekkepMiktari)
            {
                MurekkepMiktari = 0;
            }
            else
            {
                MurekkepMiktari -= yazi.Length * 2;
            }

        }
    }
}
