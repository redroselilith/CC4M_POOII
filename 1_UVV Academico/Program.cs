ProfDe professorDE = new()
{
    Nome = "Hanna Park",
    Matricula = 123,
    CargaHoraria = 40
};

professorDE.CalcularBeneficio();
Console.WriteLine($"Professor Dedicação Exclusiva: {professorDE.Nome} - Benefício: {professorDE.GetBeneficio()}");

ProfHorista professorHorista = new()
{
    Nome = "Nevena Caprini",
    Matricula = 125,
    CargaHoraria = 40,
    ValorHora = 50
};

professorHorista.CalcularBeneficio();
Console.WriteLine($"Professor Horista: {professorHorista.Nome} - Benefício: {professorHorista.GetBeneficio()}");
