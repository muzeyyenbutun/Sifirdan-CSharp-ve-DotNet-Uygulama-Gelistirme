namespace SoyutSiniflar
{
    interface IAlan
    {
        float Alan();
    }
    interface ICevre
    {
        float Cevre();
    }
    interface ISekil : IAlan, ICevre
    {
        int Hacim();
    }
    class Küp : IAlan, ICevre
    {
        public int Hacim()
        {
            return 0;
        }
        public float Alan()
        {
            return 0;
        }

        public float Cevre()
        {
            return 0;
        }
    }
    class Class1
    {

    }
    class Class2
    {

    }
    class Class3 : Class1, ICevre, IAlan
    {
        public float Alan()
        {
            return 0;
        }

        public float Cevre()
        {
            return 0;
        }
    }
    abstract class SekilBase : Class2, ISekil
    {
        public float Cevre()
        {
            return 0;
        }
        public abstract float Alan();

        public int Hacim()
        {
            return 0;
        }
    }
}
