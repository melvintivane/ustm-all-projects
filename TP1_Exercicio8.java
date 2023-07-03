import java.util.StringTokenizer;
import java.util.Scanner;

public class TP1_Exercicio8 {

	public static void main(String[] args) {
		
		try (Scanner scanner = new Scanner(System.in)) {
			//Declaração das Variáveis e input de valores
			System.out.print("Introduza 4 nomes de automóveis, separados por ponto e vírgula: ");
			String nomesAutomoveis = scanner.nextLine();
			
			//Separa os nomes (via métodos da classe StringTokenizer)
			StringTokenizer divideAFrase = new StringTokenizer(nomesAutomoveis, ";");
			
			//Array unidimensional (que armazena dados tipo String)
			String recebeToken[] = new String[4];
			
			//Imprime no ecrã o conteúdo do array unidimensional
			while(divideAFrase.hasMoreElements()) {
				for(int i = 0; i < recebeToken.length; i++) {
					recebeToken[i] = divideAFrase.nextToken();
					System.out.println(recebeToken[i]);
				}
				
			}
		}

	}
}
