import java.util.Scanner;
public class TP1_Exercicio4 {

	public static void main(String[] args) {
		try (Scanner scanner = new Scanner(System.in)) {
			System.out.print("Informe o valor: ");
			int fatorial = scanner.nextInt();
			
			
			fatWhile(fatorial);
			fatDoWhile(fatorial);
			fatFor(fatorial);
		}

	}

	
//	NÚMERO 1
	public static int fatWhile(int x) {
		int fat = 1;
		if (x > 1) {
			while (x > 1) {
			fat = fat * x;
			x--;
			}
			System.out.println(" ");
			System.out.println("Fatorial: " + fat);
		} else {
			System.out.println(" ");
			System.out.println("Fatorial: " + fat);
		}
		return fat;
	}
	
//	NÚMERO 2
	public static int fatDoWhile(int x) {
		int fat = 1;
		if (x > 1) {
			do {
				fat = fat * x;
				x--;
			}
			while(x > 1);
			System.out.println(" ");
			System.out.println("Fatorial: " + fat);
		}else {
			System.out.println(" ");
			System.out.println("Fatorial: " + fat);
		}
		return fat;
	}
	
//	NÚMERO 3
	public static int fatFor(int x) {
		int fat = 1;
		if(x > 1) {
			for(int i = x; i > 1; i--) {
				fat = fat * i;
			}
			System.out.println(" ");
			System.out.println("Fatorial: " + fat);	
		}else {
			System.out.println(" ");
			System.out.println("Fatorial: " + fat);
		}
		return fat;
	}
		

}
