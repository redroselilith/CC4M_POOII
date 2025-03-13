public class ProfDe : Professor
{
    public override void CalcularBeneficio()
    {
        Beneficio = CargaHoraria * 50;
    }
}
