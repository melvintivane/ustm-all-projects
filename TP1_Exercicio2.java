import java.util.Scanner;
public class TP1_Exercicio2 {

	public static void main(String[] args) {
		try (Scanner scanner = new Scanner(System.in)) {
			
//	NÚMERO 1
//	Alínea a
			//Input dos dados
//			System.out.println("==========SOMA========");
//			System.out.print("Informe o primeiro valor: ");
//			double Soma_num1 = scanner.nextDouble();
//			System.out.print("Informe o segundo valor: ");
//			double Soma_num2 = scanner.nextDouble();
//			System.out.print("Informe o terceiro valor: ");
//			double Soma_num3 = scanner.nextDouble();
			
//			double resultSoma = soma(Soma_num1, Soma_num2, Soma_num3);
//			System.out.println("O resultado da soma é: " + resultSoma);
			
			
//	Alínea b
			//Input de dados
//			System.out.println("==========SUBTRAÇÃO========");
//			System.out.print("Informe o primeiro valor: ");
//			int Sub_num1 = scanner.nextInt();
//			System.out.print("Informe o segundo valor: ");
//			int Sub_num2 = scanner.nextInt();
//			System.out.print("Informe o terceiro valor: ");
//			int Sub_num3 = scanner.nextInt();
			
//			int resultSub = subtrai(Sub_num1, Sub_num2, Sub_num3);
//			System.out.println("O resultado da subtração é: " + resultSub);
			

//	Alínea c
			//Input de dados
//			System.out.println("==========MULTIPLICAÇÃO========");
//			System.out.print("Informe o primeiro valor: ");
//			double Multi_num1 = scanner.nextDouble();
//			System.out.print("Informe o segundo valor: ");
//			double Multi_num2 = scanner.nextDouble();
//			System.out.print("Informe o terceiro valor: ");
//			double Multi_num3 = scanner.nextDouble();
			
//			double resultMulti = multiplica(Multi_num1, Multi_num2, Multi_num3);
//			System.out.println("O resultado da multiplicação é: " + resultMulti);
		

//	Alínea d
			//Input dos dados
//			System.out.println("==========DIVISÃO========");
//			System.out.print("Informe o primeiro valor: ");
//			double Div_num1 = scanner.nextDouble();
//			System.out.print("Informe o segundo valor: ");
//			double Div_num2 = scanner.nextDouble();
//			System.out.print("Informe o terceiro valor: ");
//			double Div_num3 = scanner.nextDouble();
					
//			double resultDiv = divide(Div_num1, Div_num2, Div_num3);
//			System.out.println("O resultado da divisão é: " + resultDiv);
			
			
//	Alínea e
			//Input dos dados
//			System.out.println("==========RESTO DA DIVISÃO========");
//			System.out.print("Informe o primeiro valor: ");
//			int resDiv_num1 = scanner.nextInt();
//			System.out.print("Informe o segundo valor: ");
//			int resDiv_num2 = scanner.nextInt();
//			System.out.print("Informe o terceiro valor: ");
//			int resDiv_num3 = scanner.nextInt();
							
//			int resDivResult = restoDivisao(resDiv_num1, resDiv_num2, resDiv_num3);
//			System.out.println("O resto da divisão dos dois primeiros números é: " + resDivResult);
			
			
//	==================================================================================================		
//	NÚMERO 2
//	Alínea a
			//Input dos dados
//			System.out.println("==========CÁLCULO DA PERÍMETRO DO RECTÂNGULO========");
//			System.out.print("Informe a base do rectângulo: ");
//			double base = scanner.nextDouble();
//			System.out.print("Informe a altura rectângulo: ");
//			double altura = scanner.nextDouble();
			
//			//Cálculo e impressão do resultado no ecrã
//			double perimetro = perimetroRectangulo(base, altura);
//			System.out.println("O perímetro do rectângulo é: " + perimetro);
			
			
//	Alínea b
			//Input dos dados
//			System.out.println("==========CÁLCULO DA ÁREA DO RECTÂNGULO========");
//			System.out.print("Informe a base do rectângulo: ");
//			double base_1 = scanner.nextDouble();
//			System.out.print("Informe a altura rectângulo: ");
//			double altura_1 = scanner.nextDouble();
			
			//Cálculo e impressão do resultado no ecrã
//			double area = areaRectangulo(base_1, altura_1);
//			System.out.println("A área do rectângulo é: " + area);
			
			
//	Alínea c
			//Input dos dados
//			System.out.println("==========CÁLCULO DO VOLUME DO CILINDRO========");
//			System.out.print("Informe a base do rectângulo: ");
//			double raio = scanner.nextDouble();
//			System.out.print("Informe a altura rectângulo: ");
//			double altura_2 = scanner.nextDouble();
			
//			//Cálculo e impressão do resultado no ecrã
//			double volume = volumeCilindro(raio, altura_2);
//			System.out.println("O volume do cilindro é de: " + volume);
		
	
//	==================================================================================================
//		NÚMERO 3
			System.out.println("NÚMERO 3");
		//Alínea a
			Boolean isEqual = booleanOr();
			System.out.println("Alínea a: " + isEqual);
//			Valor Lógico Boolean "OU Inclusivo":	
//			=> Retorna True se A ou B forem True. Senão retorna False;
//			=> Ambas expressões A e B são sempre avaliadas	
			
			
		//Alínea b
			Boolean isEqual1 = booleanAnd();
			System.out.println("Alínea b: " +isEqual1);
//			Valor Lógico Boolean "E":	
//			=> Retorna True se A e B forem True. Senão retorna False;
//			=> Ambas expressões A e B são sempre avaliadas.
			
			
		//Alínea c
			Boolean isEqual2 = booleanOr1();
			System.out.println("Alínea c: " +isEqual2);
//			Valor Lógico Boolean "OU Exclusivo":	
//			=> Retorna True se A for True e B for False ou vice-versa. Senão retorna False.
			
		//Alínea d
			Boolean isEqual3 = booleanNot();
			System.out.println("Alínea d: " +isEqual3);
//			Valor Lógico "Não":
//			=> Retorna True se A for False. Senão retorna False.
			
		//Alínea e
			Boolean isEqual4 = booleanOr2();
			System.out.println("Alínea e: " +isEqual4);
//			Valor Lógico "OU":	
//			=> Retorna True se A ou B for True. Senão retorna False;
//			=> Se A for True, B não é avaliada.

			
		//Alínea f
			Boolean isEqual5 = booleanAnd1();
			System.out.println("Alínea f: " +isEqual5);
//			Valor Lógico "E":	
//			=> Retorna True se A e B forem True. Senão retorna False;
//			=> Se A for False, B não é avaliada.
			
			
//	==================================================================================================
//	NÚMERO 4
		System.out.println("");
		System.out.println("NÚMERO 4");
		//Alínea a
			Boolean isGreater = booleanMaior();
			System.out.println("Alínea a: " + isGreater);
//			Maior:	
//			=> Utilizado quando desejamos verificar se uma variável é maior que a outra.	
			
			
		//Alínea b
			Boolean isGreater1 = booleanMenor();
			System.out.println("Alínea b: " +isGreater1);
//			Menor:	
//			=> Utilizado quando desejamos verificar se uma variável é menor que a outra.
			
			
		//Alínea c
			Boolean isGreater2 = booleanMaiorIgual();
			System.out.println("Alínea c: " +isGreater2);
//			Maior ou Igual:	
//			=> Utilizado quando desejamos verificar se uma variável é maior ou igual a outra.
			
		//Alínea d
			Boolean isGreater3 = booleanMenorIgual();
			System.out.println("Alínea d: " +isGreater3);
//			Menor ou Igual:
//			=> Utilizado quando desejamos verificar se uma variável é menor ou igual a outra.
			
		//Alínea e
			Boolean isGreater4 = booleanNaoIgual();
			System.out.println("Alínea e: " +isGreater4);
//			Não Igual:	
//			=> Utilizado quando desejamos verificar se uma variável é diferente da outra.

			
		//Alínea f
			Boolean isGreater5 = booleanIgual();
			System.out.println("Alínea f: " +isGreater5);
//			Igualdade:	
//			=> Utilizado quando desejamos verificar se uma variável é igual a outra.
			
			
//	NÚMERO 5
			//Variáveis
//			char caracter1 = 'c';
//			char caracter2 = 'j';
			
			//Verificação das Condições
//			if (caracter1 == caracter2) {
//				System.out.println("Os caracteres “caracter1” e “caracter2” são iguais.");
//			}else {
//				System.out.println("Os caracteres “caracter1” e “caracter2” são diferentes.");
//			}
			
			
//	NÚMERO 6
			//Input de dados
//			System.out.print("Informe a primeira frase: ");
//			String frase = scanner.nextLine();
//			System.out.print("Informe a segunda frase: ");
//			String frase1 = scanner.nextLine();
//			Boolean isEqual = frase.equals(frase1);
			
//			if(isEqual) {
//				System.out.println(" ");
//				System.out.print("As strings “" + frase + "” e “" + frase1 + "” são iguais.");
//			}else {
//				System.out.println(" ");
//				System.out.print("As strings “" + frase + "” e “" + frase1 + "” são diferentes.");
//			}
			
					
			
		}
	}

//	SUBPROGRAMAS ou MÉTODOS
//	NÚMERO 1
	//Soma
	public static double soma(double num1, double num2, double num3){
		double resultado = num1 + num2 + num3;
		return resultado;
	}
			
	//Subtração
	public static int subtrai(int num1, int num2, int num3){
		int resultado = num1 - num2 - num3;
		return resultado;
	}
			
	//Multiplicação
	public static double multiplica(double num1, double num2, double num3){
		double resultado = num1 * num2 * num3;
		return resultado;
	}
			
	//Divisão
	public static double divide(double num1, double num2, double num3){
		double resultado = num1 / num2 / num3;
		return resultado;
	}
			
	//Resto da divisão
	public static int restoDivisao(int num1, int num2, int num3){
		int resultado = num1 % num2;
		return resultado;
	}
	
//	==================================================================================================	
//	NÚMERO 2
	
	//Perímetro
	public static double perimetroRectangulo(double num1, double num2){
		double perimetro = (2*num1) / (2*num2);
		return perimetro;
	}
	
	//Área
	public static double areaRectangulo(double num1, double num2){
		double area = num1 * num2;
		return area;
	}
	
	//Área
	public static double volumeCilindro(double num1, double num2){
		double volume = 3.14 * Math.sqrt(num1) * num2;
		return volume;
	}
	
//	==================================================================================================	
//	NÚMERO 3
	
	//Alínea a
	public static boolean booleanOr(){
		var result = (5 >= 3 | 4 < 6);
		return result;
	}
	
	//Alínea b
	public static boolean booleanAnd(){
		var result = (3 >= 3 & 2 > 3);
		return result;
	}
	
	//Alínea c
	public static boolean booleanOr1(){
		var result = (3 == 3 ^ 5 == 2);
		return result;
	}
		
	//Alínea d
	public static boolean booleanNot(){
		var result = (4 != 3);
		return result;
	}
	
	//Alínea e
	public static boolean booleanOr2(){
		var result = (6 != 6 || 2 > 5);
		return result;
	}
	
	//Alínea f
	public static boolean booleanAnd1(){
		var result = (6 != 6 && 2 > 5);
		return result;
	}
	
	
//	==================================================================================================	
//	NÚMERO 4
	
	//Alínea a
	public static boolean booleanMaior(){
		var result = (6 > 6);
		return result;
	}
	
	//Alínea b
	public static boolean booleanMenor(){
		var result = (20 < 2);
		return result;
	}
	
	//Alínea c
	public static boolean booleanMaiorIgual(){
		var result = (30 >= 25.6);
		return result;
	}
		
	//Alínea d
	public static boolean booleanMenorIgual(){
		var result = (100 <= 100);
		return result;
	}
	
	//Alínea e
	public static boolean booleanNaoIgual(){
		var result = (2 != 1);
		return result;
	}
	
	//Alínea f
	public static boolean booleanIgual(){
		var result = (0 == 0);
		return result;
	}
	
}
