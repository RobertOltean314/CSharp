
public class BankAccount
{
    // Verifica putin aici accesul la variabilele astea, 
    // nu stiu daca voiai sa fie toate publice sau nu. 
    // (poate de ex voiai sa le poti instantia doar la run-time, si sa nu fie publice)
    public int _id;
    public int _pin;
    public double _sum_lei;
    public double _sum_euro;
    public double _sum_dollar;

    public BankAccount(int id, int pin, double sum_lei, double sum_euro, double sum_dolar)
    {
        _id = id;
        _pin = pin;
        _sum_lei = sum_lei;
        _sum_euro = sum_euro;
        _sum_dollar = sum_dolar;
    }
}
