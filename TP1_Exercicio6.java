import java.util.Scanner;
import java.util.Random;

public class TP1_Exercicio6 {

	public static void main(String[] args) {
		
		try (Scanner scanner = new Scanner(System.in)) {
			
//		NÚMERO 1
			//Input de Dados 
//			System.out.print("Informe o valor: ");
//			double num = scanner.nextDouble();
			
			//Método para o Cálculo da Raiz Quadrada
//			raizQuadrada(num);
			
			
//		NÚMERO 2
			//Input de Dados 
//			System.out.print("Informe a base: ");
//			double num1 = scanner.nextDouble();
//			System.out.print("Informe o expoente: ");
//			double expoente = scanner.nextDouble();
			
			//Método para o Cálculo da Potência
//			potencia(num1, expoente);
			
			
//		NÚMERO 3
			//Input de Dados 
//			System.out.print("Informe a base: ");
//			double num2 = scanner.nextDouble();
//			System.out.print("Informe o expoente: ");
//			double expoente1 = scanner.nextDouble();
				
			//Método para o Cálculo da Potência
//			arredondarPotencia(num2, expoente1);
			

//		NÚMERO 4
			//Método para números aleatórios
//			numsAleatorios();
		
			
			
//		Os exercícios que se seguem estão no método MAIN pois os mesmos não exigiam que estivessem em subprogramas
//		NÚMERO 5
			//Apresenta no ecrã o número de caracteres da frase
//			System.out.print("Digite a frase: ");
//			String frase = scanner.nextLine();
//			System.out.println("Número de caracteres da frase: " + frase.length());
			
//		NÚMERO 6
			//Apresenta no ecrã a posição do caractere
//			System.out.print("Digite a frase: ");
//			String frase_1 = scanner.nextLine();
//			System.out.println("Caractere no índice 0: " + frase_1.charAt(0));
//			System.out.println("Caractere no índice 1: " + frase_1.charAt(1));
			
//			NÚMERO 6
			//Comparação de duas frases(sem ter em conta se são maiúsculas ou minúsculas)
//			System.out.print("Digite a primeira frase: ");
//			String frase_1 = scanner.nextLine();
//			System.out.print("Digite a segunda frase: ");
//			String frase_2 = scanner.nextLine();
//			Boolean isEqual = frase_1.equalsIgnoreCase(frase_2);
			
//			if(isEqual) {
//				System.out.println(" ");
//				System.out.print("As frases “são iguais”.");
//			}else {
//				System.out.println(" ");
//				System.out.print("As frases “são diferentes”.");
//			}
			
			
		}
	}
	
	
//	===================================================================================================	
//	Subprogramas ou Métodos Secundários
//	NÚMERO 1
	//Raiz Quadrada de Um Número
	public static double raizQuadrada(double num_1) {
		double result = Math.sqrt(num_1);
		System.out.print("Resultado: " + result);
		return result;
	}
	
//	NÚMERO 2
	//Potência de Um Número
	public static double potencia(double num_1, double exp) {
		double result = Math.pow(num_1, exp);
		System.out.print("Resultado: " + result);
		return result;
	}
	
//	NÚMERO 3
	//Potência de Um Número e Arredontamento
	public static double arredondarPotencia(double num_1, double num_exp) {
		double result = Math.pow(num_1, num_exp); 
		double result2 = Math.round(result);
		System.out.print("Resultado: " + result2);
		return result2;
	}
	
//	NÚMERO 4
	//Gera Números Aleatórios
	public static int numsAleatorios() {
		Random gerar = new Random();
		
		for(int i = 1; i < 11; i++) {
			int number = gerar.nextInt(60);
			System.out.println(i + ". Numero Aleatório: " + number);
		}
		return 0;
	}

}
