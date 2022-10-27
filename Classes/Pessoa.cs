using UC12_ER2_ER5.Interfaces;

namespace UC12_ER2_ER5.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }

        public Endereco ?endereco { get; set; }

        public float ?rendimento { get; set; }
        
        

        public abstract float PagarImposto(float rendimento);
        
    }
}