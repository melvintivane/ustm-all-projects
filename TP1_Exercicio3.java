import java.util.Scanner;

public class TP1_Exercicio3 {

	public static void main(String[] args) {
		try (Scanner scanner = new Scanner(System.in)) {
			
//	NÚMERO 1
			//Declaração das Variáveis
//			double Quadril = 0;
//			double altura = 0;
//			int Gender = 0;
					
			//Atribuíção de Valores às Variáveis
//			System.out.println("1. Masculino");
//			System.out.println("2. Femenino");
//			System.out.print("Seleccione o seu gênero: ");
//			Gender = scanner.nextInt();
//			System.out.print("Digite o tamanho do quadril: ");
//			Quadril = scanner.nextDouble();
//			System.out.print("Digite a altura: ");
//			altura = scanner.nextDouble();
//			System.out.println("");
			
//			//Método para o Cálculo do Índice de Adiposidade Corporal (IAC)
//			IAC(Quadril, altura, Gender);
			
			
//	NÚMERO 2
			//Declaração das Variáveis
//			double Teste1;
//			double Teste2;
//			double TP1;
//			double TP2;
			
			//Atribuíção de Valores às Variáveis
//			System.out.print("Digite a nota do 1º Teste: ");
//			Teste1 = scanner.nextDouble();
//			System.out.print("Digite a nota do 2º Teste: ");
//			Teste2 = scanner.nextDouble();
//			System.out.print("Digite a nota do 1º Trabalho: ");
//			TP1 = scanner.nextDouble();
//			System.out.print("Digite a nota do 2º Trabalho: ");
//			TP2 = scanner.nextDouble();
//			System.out.println(" ");
			
			//Método para Cálculo da Frequência
//			N_Frequencia(Teste1, Teste2, TP1, TP2);
		}
	}
	
	
//	SUBPROGRAMAS ou MÉTODOS
//	NÚMERO 1
	public static double IAC(double quadril, double altura, double genero) {
		//Cálculo do Índice de Adiposidade Corporal (IAC)
		double IAC = (quadril / (altura * Math.sqrt(altura) )) - 18;
	
		//Verificação das Condições
		if(genero == 1) {
			if(IAC >= 8 && IAC <= 20) {
				System.out.println("IAC: " + IAC);
				System.out.println("Adiposidade normal.");
			}else if(IAC >= 21 && IAC <= 25) {
				System.out.println("IAC: " + IAC);
				System.out.println("Sobrepeso.");
			}else if(IAC > 25) {
				System.out.println("IAC: " + IAC);
				System.out.println("Obesidade.");
			}
		}else if(genero == 2) {
			if(IAC >= 21 && IAC <= 31) {
				System.out.println("IAC: " + IAC);
				System.out.println("Adiposidade normal.");
			}else if(IAC >= 33 && IAC <= 38) {
				System.out.println("IAC: " + IAC);
				System.out.println("Sobrepeso.");
			}else if(IAC > 38) {
				System.out.println("IAC: " + IAC);
				System.out.println("Obesidade.");
			}	
		}else {
			System.out.print("A opção de gênero seleccionada não existe. Tente novamente!");
		}
		return genero;
	}
	
	
//	==================================================================================================
//	NÚMERO 2
	public static double N_Frequencia(double Teste1, double Teste2, double TP1, double TP2) {		
	//Cálculo da Média
		double media = 0.5 * ((Teste1 + Teste2) /2) + 0.5 * ((TP1 + TP2) /2);
		
	//Verificação das Condições
		if(media >=10) {
			System.out.println("Média: " + media);
			System.out.println("Estudante admitido ao exame.");
		}else {
			System.out.println("Média: " + media);
			System.out.println("Estudante não admitido ao exame.");
		}
		return media;
	}
}
