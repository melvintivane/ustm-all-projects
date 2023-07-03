
public class OpLogi {

	public static void main(String[] args) {
			
		// operador ou simples
	    boolean ress = ouSimplesBoolean(16,5,4,2);
		System.out.println("Resultado: " +ress);
		
		// operador e simples
	    boolean ress1 = eeBoolean(16,5,4,2);
		System.out.println("Resultado: " +ress1);

		// operador ou
	    boolean ress2 = ouBoolean(16,5,4,2);
		System.out.println("Resultado: " +ress2);
		
		// operador e 
	    boolean ress3 = eBoolean(16,5,4,2);
		System.out.println("Resultado: " +ress3);

		//operador operador ou esclusivo 
	    boolean ress4 = ou1Boolean(16,5,4,2);
		System.out.println("Resultado: " +ress4);


	}

//	SUBPROGRAMAS ou MÉTODOS
	// operador "OU SIMPLES"
	public static boolean ouSimplesBoolean(double a, double b, double c, double d) {
		boolean res = (a>=b) | (c>d);
		return res;	
	} 
	
	// operador "E SIMPLES"
	public static boolean eeBoolean(double a, double b, double c, double d) {
		boolean res = (a>=b) & (c>d);
		return res;	
	}
	
	// operador "OU"
	public static boolean ouBoolean(double a, double b, double c, double d) {
		boolean res = (a>=b) || (c>d);
		return res;	
	}
	
	// operador "E"
	public static boolean eBoolean(double a, double b, double c, double d) {
		boolean res = (a>=b) && (c>d);
		return res;		
	}
	
	// operador "OU EXCLUSIVO" 
	public static boolean ou1Boolean(double a, double b, double c, double d) {
		boolean res = (a>=b) ^ (c>d);
		return res;	
    }

}

