namespace InventoryControl.Util
{
    public class StatesEnum
    {
        public string Value { get; set; }

        private StatesEnum(string value)
        {
            Value = value;
        }

        public static StatesEnum Acre => new StatesEnum("Acre");
        public static StatesEnum Alagoas => new StatesEnum("Alagoas");
        public static StatesEnum Amapa => new StatesEnum("Amapá");
        public static StatesEnum Amazonas => new StatesEnum("Amazonas");
        public static StatesEnum Bahia => new StatesEnum("Bahia");
        public static StatesEnum Ceara => new StatesEnum("Ceará");
        public static StatesEnum DistritoFederal => new StatesEnum("Distrito Federal");
        public static StatesEnum EspiritoSanto => new StatesEnum("Espírito Santo");
        public static StatesEnum Goias => new StatesEnum("Goiás");
        public static StatesEnum Maranhao => new StatesEnum("Maranhão");
        public static StatesEnum MatoGrosso => new StatesEnum("Mato Grosso");
        public static StatesEnum MatoGrossoDoSul => new StatesEnum("Mato Grosso do Sul");
        public static StatesEnum MinasGerais => new StatesEnum("Minas Gerais");
        public static StatesEnum Para => new StatesEnum("Pará");
        public static StatesEnum Paraiba => new StatesEnum("Paraíba");
        public static StatesEnum Parana => new StatesEnum("Paraná");
        public static StatesEnum Pernambuco => new StatesEnum("Pernambuco");
        public static StatesEnum Piaui => new StatesEnum("Piauí");
        public static StatesEnum RioDeJaneiro => new StatesEnum("Rio de Janeiro");
        public static StatesEnum RioGrandeDoNorte => new StatesEnum("Rio Grande do Norte");
        public static StatesEnum RioGrandeDoSul => new StatesEnum("Rio Grande do Sul");
        public static StatesEnum Rondonia => new StatesEnum("Rondônia");
        public static StatesEnum Roraima => new StatesEnum("Roraima");
        public static StatesEnum SantaCatarina => new StatesEnum("Santa Catarina");
        public static StatesEnum SaoPaulo => new StatesEnum("São Paulo");
        public static StatesEnum Sergipe => new StatesEnum("Sergipe");
        public static StatesEnum Tocantins => new StatesEnum("Tocantins");
    }
}
