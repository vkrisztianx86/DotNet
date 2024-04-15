using DaraboloOsztalyLib;

Szodarabolo sd1 = new Szodarabolo();
Szodarabolo sd2 = new Szodarabolo();

sd1.Kiiras();

if (sd1.AdatBekeres())
{
    sd1.Kiiras();
}

if (sd2.AdatBekeres())
{
    sd2.Kiiras();
}

if (sd1.Sikeres)
{
    sd1.Kiiras();
}