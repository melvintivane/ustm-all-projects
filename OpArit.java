
public class OpArit {

	public static void main(String[] args) {
		
		//Chamada do Método SOMA
		double sum_num1 = 5;
		double sum_num2 = 5;
		soma(sum_num1, sum_num2);
		
		//Chamada do Método da SUBTRAÇÃO
		int sub_num1 = 5;
		int sub_num2 = 2;
		subtrai(sub_num1, sub_num2);
		
		//Chamada do Método da MULTIPLICAÇÃO
		double multi_num1 = 5;
		double multi_num2 = 2;
		multiplica(multi_num1, multi_num2);
		
		//Chamada do Método da DIVISÃO
		double div_num1 = 5;
		double div_num2 = 2;
		divide(div_num1, div_num2);

	}
	
	//Soma 
	public static double soma(double a, double b) {
		double res = a + b;
		System.out.println("Resultado: " + res);
		return res;	
	} 
		
	//Subtração
	public static int subtrai(int a, int b) {
		int res = a - b ;
		System.out.println("Resultado: " + res);
		return res;
	}
		
	//Multiplicação 
	public static double multiplica(double a, double b) {
		double res = a * b ;
		System.out.println("Resultado: " + res);
		return res;
	}
	
	//Divisão 
	public static double divide( double a, double b) {
		double res = a / b ;
		System.out.println("Resultado: " + res);
		return res;
	}

}
