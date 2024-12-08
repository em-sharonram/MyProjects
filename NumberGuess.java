package numberguess;

/*
 This program is for a simple number guessing game
 */

public class NumberGuess {
public static void main(String[] args) {
	int randNum, guessNum, attemptNum; // Define program variables
	
	randNum = new java.util.Random().nextInt(10) + 1; // Generate a random number between 1 and 10
	
	System.out.println("I am thinking of a random number between 1 and 10"); // Display a message
	
	// Ask for a guess and check the input
	for (attemptNum = 1; attemptNum <= 3; attemptNum++) {
		System.out.print("Guess what it is?");
		java.util.Scanner scan = new java.util.Scanner(System.in);
		guessNum = scan.nextInt();
		System.out.println("You guessed " + guessNum);
		
		if (guessNum == randNum) {
			System.out.println("You guessed it!");
			break;			
		}
			System.out.println("Sorry, try again!");
		}
	}
}
