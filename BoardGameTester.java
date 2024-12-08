package games.boards;

import games.boards.*;

public class BoardGameTester {
    public static void main(String[] args) {
        // Create boards
    	Board ticTacToeBoard = new Board (3, 3);
    	Board connectFourBoard = new Board (6, 7);
    	Board mastermindBoard = new Board (5, 8);


        // Set cells
    	ticTacToeBoard.setCell(Mark.CROSS, 1, 1);  // Set a cell to cross
        connectFourBoard.setCell(Mark.RED, 0, 1); // Set a cell to red
        mastermindBoard.setCell(Mark.YELLOW, 0, 0); // Set to Mastermind colors
        mastermindBoard.setCell(Mark.RED, 0, 1);
		mastermindBoard.setCell(Mark.GREEN, 0, 2);
		mastermindBoard.setCell(Mark.BLUE, 0, 3);
		mastermindBoard.setCell(Mark.MAGENTA, 0, 4);
		mastermindBoard.setCell(Mark.ORANGE, 0, 5);
		
        // Display boards
        System.out.println("Tic-Tac-Toe Board:");
        System.out.println(ticTacToeBoard);

        System.out.println("Connect Four Board:");
        System.out.println(connectFourBoard);

        System.out.println("Mastermind Board:");
        System.out.println(mastermindBoard);
    }
}

