//import java.util.Scanner;
public class TP1_Exercicio5 {

	public static void main(String[] args) {
		
		//Método para ler dez números e	armazenados em um array
//		arrayUnidimensional(null);
		
		//Método para ler dez números e	armazenados em um array
//		arrayBidimensional(null);
		
	}
	
//	SUBPROGRAMAS OU MÉTODOS SECUNDÁRIOS
//	NÚMERO 1
	public static int[] arrayUnidimensional(Integer[] num) {
		int[] num1 = new int[10];
		num1[0] = 5;
		num1[1] = 7;
		num1[2] = 5;
		num1[3] = 7;
		num1[4] = 5;
		num1[5] = 7;
		num1[6] = 5;
		num1[7] = 7;
		num1[8] = 5;
		num1[9] = 7;
		
		for(int i = 0; i < num1.length; i++) {
			System.out.println("Posição " + i + " => Número: " + num1[i]);
		}
		
		return num1;
	}
	
//	NÚMERO 2
	public static String[][] arrayBidimensional(String[][] num) {
		String[][] num1 = new String[5][2];
		num1[0][0] = "Melvin Tivane";
		num1[1][0] = "Radek Buanali";
		num1[2][0] = "Tony Stark";
		num1[3][0] = "Bruce Wayne";
		num1[4][0] = "Elon Musk";
		num1[0][1] = "+258 842074393";
		num1[1][1] = "+258 861421557";
		num1[2][1] = "+258 842074393";
		num1[3][1] = "+258 861421557";
		num1[4][1] = "+258 842074393";
		
		for(int i = 0; i < num1.length; i++) {
			System.out.println(i + ". Nome e Número: " );
			for(int j = 0; j < num1[0].length; j++) {
				System.out.println("=> " + num1[i][j]);
			}
			System.out.println("");
		}
		
		return num1;
	}
	
}
