namespace aula48_exercicio {
    class ConversorDeMoeda {

        public static double IoF = 0.06;
        public static double convert(double cotacao, int quantidade) {
            return ((cotacao * quantidade) + ((cotacao * quantidade) * IoF));
        }
    }
}
