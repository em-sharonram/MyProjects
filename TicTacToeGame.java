package tictactoegame;

/*
This program is a text-based Tic-Tac-Toe game
*/

public class TicTacToeGame {
	static int[][] gameboard; // Declare variable
	static final int EMPTY = 0; // Declare constants
	static final int NOUGHT = -1;
	static final int CROSS = 1;
	private static java.util.Scanner scan;
	
	/* Set a square on the board must be empty */
	static void set(int val, int row, int col)
	throws IllegalArgumentException {
		if (gameboard[row][col] == EMPTY)
			gameboard[row][col] = val;
		else throw new IllegalArgumentException("Player already there!");
	}
	
	/* display the board */
	static void displayBoard() {
		for (int r = 0; r < gameboard.length; r++) {
			System.out.print("|");
			for (int c = 0; c < gameboard[r].length; c++) {
				switch(gameboard[r][c]) {
				case NOUGHT:
					System.out.print("O");
					break;
				case CROSS:
					System.out.print("X");
					break;
				default: // Empty
					System.out.print(" ");
				}
				System.out.print("|");
			}
			System.out.println("\n-------");
		}
	}
	
	static void createBoard(int rows, int cols) {
		// TODO initialize the game board
		gameboard = new int[rows][cols];
		for (int r = 0; r < rows; r++) {
			for (int c = 0; c < cols; c++) {
				gameboard[r][c] = EMPTY;
			}
		}
	}

	static int winOrTie() {
		// TODO Determine whether X or O won or there is a tie
		for (int i = 0; i < gameboard.length; i++) {
			if (gameboard[i][0] != EMPTY && gameboard[i][0] == gameboard[i][1] && gameboard[i][1] == gameboard[i][2])
				return gameboard[0][i];
			if (gameboard[0][i] != EMPTY && gameboard[0][i] == gameboard[1][i] && gameboard[1][i] == gameboard[2][i])
				return gameboard[0][i];
		}
		
		// Check diagonals for a win
		if (gameboard [0][0] != EMPTY && gameboard[0][0] == gameboard[1][1] && gameboard[1][1] == gameboard[2][2])
				return gameboard[0][0];
		if (gameboard[0][2] != EMPTY && gameboard[0][2] == gameboard[1][1] && gameboard[1][1] == gameboard[2][0])
			return gameboard[0][2];
		
		// Check for a tie
		for (int[] row : gameboard) {
			for (int cell : row) {
				if (cell == EMPTY)
					return 2; // Game is going
			}
		}
		
		return 0; // It's a tie
	}
	
	// Main Method
	public static void main(String[] args) {
		createBoard(3, 3);
		int turn = 0;
		int playerVal;
		int outcome;
		scan = new java.util.Scanner(System.in);
		
		do {
			displayBoard();
			playerVal = (turn % 2 == 0) ? NOUGHT : CROSS;
			if (playerVal == NOUGHT)
				System.out.println("\n—O's turn—");
			else
				System.out.println("\n—X's turn—");
			System.out.print("Enter row and column: ");
			try {
				set(playerVal, scan.nextInt(), scan.nextInt());
			} catch (Exception ex) {
				System.err.println(ex);
				turn--; // Allow to retry
			}
			
			turn++;
			outcome = winOrTie(); // Check outcome
		} while (outcome == 2);
		
		displayBoard(); // Display final board
		
		switch(outcome) {
		case NOUGHT:
			System.out.println("O wins!");
			break;
		case CROSS:
			System.out.println("X wins!");
			break;
		case 0:
			System.out.println("Tie.");
			break;
		}
	}
}
