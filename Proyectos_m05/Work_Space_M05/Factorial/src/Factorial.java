import java.util.Scanner;

public class Factorial {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int n = 0;
		do {
			System.out.print("Introducir un numero (n>=0): ");
			n = scanner.nextInt();
		} while (n < 0);
		scanner.close();
		int fact = calculaFactorial(n);	
		System.out.println("El factorial de "+n+" es: "+fact);



	}
private static int calculaFactorial(int n) {
		
		int resultado = 1;
		
		for(int i=2; i<=n; i++) 
			resultado=resultado*i;
		return resultado;
	}


}
