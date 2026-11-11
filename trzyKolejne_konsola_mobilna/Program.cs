
abstract class Pytanie
{
    protected string trescPytania;
    protected string zdjDoPytania;
    protected bool czyPoprawna;

    public Pytanie(string trescPytaniaArg, string zdjDoPytaniaArg)
    {
        trescPytania = trescPytaniaArg;
        zdjDoPytania = zdjDoPytaniaArg;
        czyPoprawna = false;
    }

    public abstract bool sprawdzPoprawnosc(char odp);

}

class PytanieZamkniete : Pytanie
{
    private string trescOdpA;
    private string trescOdpB;
    private string trescOdpC;
    private char poprawnaOdp; //char nie string !!: (znak ‘A’ lub ‘B’ lub ‘C’), znak nie wartosc!! to samo w konstruktorze nizej i w metodzie


    public PytanieZamkniete(string trescPytaniaArg, string zdjDoPytaniaArg, string trescOdpAarg, string trescOdpBarg,
        string trescOdpCarg, char poprawnaOdparg) : base(trescPytaniaArg, zdjDoPytaniaArg)
    {
        trescOdpA = trescOdpAarg;
        trescOdpB = trescOdpBarg;
        trescOdpC = trescOdpCarg;
        poprawnaOdp = poprawnaOdparg;
        
    }

    public override bool sprawdzPoprawnosc(char odp)
    {
        if (odp == poprawnaOdp)
        {
            czyPoprawna = true;
        }
        else
        {
            czyPoprawna = false;
        }
        
        return czyPoprawna;
    }
}