using Facade.sppedChange.Contract;

namespace Facade.sppedChange
{
    public class Centralita
    {
        private IEmbrague embrague;
        private IAcelerador acelerador;
        private IPalancaCambios palancaCambios;

        public Centralita(IEmbrague embrague, IAcelerador acelerador, IPalancaCambios palancaCambios)
        {
            this.embrague = embrague;
            this.acelerador = acelerador;
            this.palancaCambios = palancaCambios;
        }

        public void AumentarMarcha()
        {
            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.PuntoMuerto();
            if (palancaCambios.GetVelocidadActual() < 5)
                palancaCambios.InsertarVelocidad(palancaCambios.GetVelocidadActual() + 1);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();
        }

        public void ReducirMarcha()
        {
            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.PuntoMuerto();
            if (palancaCambios.GetVelocidadActual() > 1)
                palancaCambios.InsertarVelocidad(palancaCambios.GetVelocidadActual() - 1);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();
        }
    }
}
