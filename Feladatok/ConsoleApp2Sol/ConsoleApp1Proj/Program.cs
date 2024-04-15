using Cutter;

Slicer sc = new Slicer();
Slicer sc2 = new Slicer();

sc.outputter();

if (sc.datarequest())
{
    sc.outputter();
}

if (sc2.datarequest())
{
    sc2.outputter();
}

if (sc.Success)
{
    sc.outputter();
}

