namespace MühürlenmisYapilar
{
    sealed class A
    {

    }
    public class B
    {

    }
    //Sorunsuz çalışır
    public class C : B
    {

    }
    //Hata verir
    public class C : A
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}