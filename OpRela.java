
public class OpRela {

	public static void main(String[] args) {
		// OPERAÇÕES RELACIONAIS
		
		//igual
	    boolean ress = igual(16,5);
		System.out.println("Resultado: " +ress);
		
		//diferente
		boolean ress1 = diferente(16,5);
		System.out.println("Resultado: " +ress1);
		
		//maior
		boolean ress2 = maior(16,5);
		System.out.println("Resultado: " +ress2);
		
		//menor
		boolean ress3 = menor(16,5);
		System.out.println("Resultado: " +ress3);
		
		// maiorOuIgual
		boolean ress4 = maiorIgual(16,5);
		System.out.println("Resultado: " +ress4);
		
		// maiorOuIgual
		boolean ress5 = menorIgual(16,5);
		System.out.println("Resultado: " +ress5);

	}
	
	// Igual 
	public static boolean igual(double a, double b) {
		boolean res = a == b;
		return res;	
	} 
	
	// Diferente 
	public static boolean diferente(double a, double b) {
		boolean res = a != b;
		return res;	
	}
		
	// Maior 
	public static boolean maior (double a, double b) {
		boolean res = a > b;
		return res;	
	}
		
	// Menor 
	public static boolean menor (double a, double b) {
		boolean res = a < b;
		return res;	
	}
		
	// Maior ou Igual
	public static boolean maiorIgual (double a, double b) {
		boolean res = a >= b;
		return res;	
    }
		
	//Menor ou Igual
	public static boolean menorIgual (double a, double b) {
		boolean res = a <= b;
		return res;	
	}

}
