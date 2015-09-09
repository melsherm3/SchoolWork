/*
 * Melissa Cunningham
 * Java Project: Waiter Helper
 * 8/6/15
 */
package waiterhelper;

import javafx.application.Application;
import static javafx.application.Application.launch;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import static javafx.scene.input.KeyCode.ESCAPE;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.scene.text.Font;
import javafx.scene.text.FontPosture;
import javafx.scene.text.Text;
import javafx.stage.Stage;

public class WaiterHelper extends Application {

//Declare number of items in menu
public static final int ITEM_COUNT = 9;  

//Declare max number of people per table
public static final int MAX_PEOPLE = 10;

//Declare sales tax amount
public static final double SALES_TAX = 0.08995;

 @Override
    public void start(Stage mainStage) { 
        //Declare variable for order total
        double orderTotal = 0;
        
        //Create an array to hold menu items
        MenuItem[] menuArray = new MenuItem[ITEM_COUNT];
        
        //Create an array to hold each person's order
        PersonOrder[] personOrder = new PersonOrder[MAX_PEOPLE];
        
        //Add blank orders to personOrder array
        createPersonOrderArray(personOrder);
        
        //Create grid pane for main details
        GridPane grid = new GridPane();
        grid.setHgap(5);
        grid.setVgap(10);        
        grid.setStyle("-fx-background-color:#a9f5a9");
        
        //Add Buttons
        Button finish = new Button("Finish");        
        finish.setStyle("-fx-font-family:tahoma; -fx-color: blue; -fx-text-fill: white;");
        Button add = new Button("Add Item");
        add.setStyle("-fx-font-family:tahoma; -fx-color: green; -fx-text-fill: white;");
        Button clear = new Button("Clear Order");
        clear.setStyle("-fx-font-family:tahoma; -fx-color: #f83e25; -fx-text-fill: white;");
        
        //Add header label
        Label welcome = new Label("Welcome to the Waiter Helper");
        welcome.setFont(Font.font("Tahoma", FontPosture.REGULAR, 25));
        welcome.setStyle("-fx-text-fill: white");
        
        //Add top HBox and header label
        HBox hbox = new HBox();
        hbox.setSpacing(10);
        hbox.setAlignment(Pos.CENTER); 
        hbox.getChildren().add(welcome);        
        hbox.setStyle("-fx-background-color:#0b0161");
        
        //Make an VBox for results
        VBox resultsBox = new VBox();
        resultsBox.setAlignment(Pos.TOP_CENTER);       
        resultsBox.setStyle("-fx-background-color:#a9f5a9");
        
        //Create order labels
        Label customerName = new Label("Customer Name: ");
        customerName.setFont(Font.font("Tahoma", FontPosture.REGULAR, 14));
        customerName.setStyle("-fx-text-fill: black; -fx-font-weight: bold;");
        Label itemNumber = new Label("Item Number: ");
        itemNumber.setFont(Font.font("Tahoma", FontPosture.REGULAR, 14));
        itemNumber.setStyle("-fx-text-fill: black; -fx-font-weight: bold;");
        Label clickFinish = new Label("Enter Tip Percent: ");
        clickFinish.setFont(Font.font("Tahoma", FontPosture.REGULAR, 14));
        clickFinish.setStyle("-fx-text-fill: #07013c; -fx-font-weight: bold;");
        
        //Add order text fields
        TextField customerNameField = new TextField();
        TextField itemNumberField = new TextField();
        TextField tipField = new TextField("20");        
        
        //Add event handler to finish button
        finish.setOnAction(new EventHandler<ActionEvent>() {
           public void handle(ActionEvent e) {               
               //Declare tip
               double tip = 0.0;
               
               //Make sure there is something in the tip field
               if(tipField.getText().isEmpty())
                     messageWindow("You must enter a value in the tip field.");
               else {               
                    try{
                         //Clear any past report that is showing up
                         resultsBox.getChildren().clear();
                         //Get the tip percent and convert it to a double
                         String tipString = tipField.getText();
                         tip = Double.parseDouble(tipString);                    
                         //Force positive tip
                         if(tip<0)
                             messageWindow("Must enter a positive percentage for a tip.");
                         else {
                             //Convert tip to decimal value
                             tip = tip/100;
                             //Calculate the order total
                             calculateBill(personOrder, orderTotal);
                             //Print the order details on the screen
                             printOrderDetails(resultsBox, personOrder, orderTotal, tip);
                         }
                    }
                    //Use messageWindow function to show any errors that come up
                    catch (Exception ex) {
                        ex.printStackTrace();
                        String error = "Error: \n" + ex.getMessage();
                        messageWindow(error);
                    }
               }
               
           } 
        });
        
        //Add event handler to add item button
        add.setOnAction(new EventHandler<ActionEvent>() {
           public void handle(ActionEvent e) {                    
                 //Make sure there is something in the fields
                 if(customerNameField.getText().isEmpty() || itemNumberField.getText().isEmpty())
                     messageWindow("You must enter a value for\nname and item number.");
                 else {
                    try {                
                             //Get name and item number from text fields
                             String name = customerNameField.getText();
                             String itemNumber = itemNumberField.getText();
                             //Convert item number to an int
                             int itemNum = Integer.parseInt(itemNumber);
                             //Add the items to the order
                             addItem(name, itemNum, menuArray, personOrder, grid);
                         }                    
                    //Use messageWindow function to show any errors that come up
                    catch (Exception ex) {
                        ex.printStackTrace();
                        String error = "Error: \n" + ex.getMessage();
                        messageWindow(error);
                    }
                 }
           } 
        }); 
        
        //Add event handler to add item button
        clear.setOnAction(new EventHandler<ActionEvent>() {
           public void handle(ActionEvent e) {
                //Clear items printed
                resultsBox.getChildren().clear();

                //Set personOrder array back to default values
                for(int i=0; i<MAX_PEOPLE; i++)
                {
                    personOrder[i].setName("");
                    personOrder[i].setTotal(0.0);
                }
           } 
        }); 
        
        //Create border pane
        BorderPane borderPane = new BorderPane();
        //Add grid to center
        borderPane.setCenter(grid);
        //Add top HBox to top
        borderPane.setTop(hbox);
        borderPane.setAlignment(hbox, Pos.CENTER);
        //Add results HBox to bottom
        borderPane.setBottom(resultsBox);
        borderPane.setAlignment(resultsBox, Pos.TOP_CENTER);
        
        //Add content to grid:
        //Add the menu text
        String menuString = writeMenu(menuArray);
        Text menu = new Text(14, 14, menuString);
        //Change font
        menu.setFont(Font.font("Tahoma", FontPosture.REGULAR, 14));
        //Add menu to the grid
        grid.add(menu, 2, 1);
        
        //Add Labels
        grid.add(customerName, 1, 2);
        grid.add(itemNumber, 1, 3);
        grid.add(clickFinish, 1, 5);
        
        //Add Text Fields
        grid.add(customerNameField, 2, 2);
        grid.add(itemNumberField, 2, 3);
        grid.add(tipField, 2, 5);
        
        //Add buttons
        grid.add(finish, 3, 5);
        grid.add(add, 3, 3);
        grid.add(clear, 3, 6);
        
        //Assign event for ESC key press
        borderPane.setOnKeyPressed(e-> {
            if(e.getCode()==ESCAPE)
                System.exit(0);               
        });
        
        //Create new scene with grid in it
        Scene scene = new Scene(borderPane, 550, 650);
        //Set main stage properties
        mainStage.setTitle("Waiter Helper");
        //Add scene to the main stage
        mainStage.setScene(scene);
        //Show the main stage
        mainStage.show();
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
              
        //Greet user
        showGreeting();
        
        //Create and display matrix
        launch(args);
    }
    
    //Greet user
    public static void showGreeting() {
       System.out.println("Welcome to the Waiter Helper.");
    }
    
    //Create person order array
    public static void createPersonOrderArray(PersonOrder[] orders){
        //Add a blank object for each spot in the array
        for(int i=0; i<MAX_PEOPLE; i++){
            orders[i] = new PersonOrder();
        }
    }
    
    //Write Menu
    public static String writeMenu(MenuItem[] menuArray){
        //Create string for menu
        String menu = String.format("%-12s%-25s%15s%n", "Item#", "Menu:", "\tPrice:");
        String price = "";
        
        //Add menu items to array
        MenuItem item1 = new MenuItem("Green Salad", 5.99, 1);
        menuArray[0] = item1;
        MenuItem item2 = new MenuItem("Soup of the Day", 5.99, 2);
        menuArray[1] = item2;
        MenuItem item3 = new MenuItem("Cheese Burger", 7.99, 3);
        menuArray[2] = item3;
        MenuItem item4 = new MenuItem("Roast Prime Rib", 15.99, 4);
        menuArray[3] = item4;
        MenuItem item5 = new MenuItem("Chicken Parmesan", 12.99, 5);
        menuArray[4] = item5;
        MenuItem item6 = new MenuItem("Ice Cream Brownie", 5.99, 6);
        menuArray[5] = item6;
        MenuItem item7 = new MenuItem("Fountain Soda", 3.99, 7);
        menuArray[6] = item7;
        MenuItem item8 = new MenuItem("Sweet Iced Tea", 3.99, 8);
        menuArray[7] = item8;
        MenuItem item9 = new MenuItem("Lemonade", 3.99, 9);
        menuArray[8] = item9;
        
        //Create string for menu
        for(int i=0; i<ITEM_COUNT; i++)
        {
            price = String.format("%.2f", menuArray[i].getPrice());
            menu += String.format("%-12s%-25s%15s%n", (menuArray[i].getItemNum() + "."), menuArray[i].getName(), ("\t$ " + price));
        }
        
        //Return menu string
        return menu;
    }
    
    //Add item for person
    public static void addItem(String name, int number, MenuItem[] menuArray, PersonOrder[] order, GridPane grid){
        //Declare string for message to show user
        String message = "Item Added";
        
        //Declare a string to hold current name
        String currentName;
        
        //Declare boolean to check if person already exists
        boolean exists = false;
        
        //Declare a boolean to check if max number of people hit
        boolean hitMax = false;
        
        //Make sure number is valid
        if(number > ITEM_COUNT || number < 1)
            message = "Invalid Item Numer";
        else {           
            //Default hitMax to true 
            hitMax = true;
            //Get price based on item number
            double price = menuArray[number-1].getPrice();
            //Go through list of names and make sure not already there
            for(int i=0; i<MAX_PEOPLE; i++) {
                //Get current name
                currentName = order[i].getName();
                //If the name is there, add the item's price and mark as exists
                if(currentName.equals(name)){
                    order[i].addItem(price);
                    exists = true;
                    hitMax = false;
                }
            }

            //If name doesn't already exist, add it with the item
            if(exists == false){                           
                //Default hitMax to true 
                hitMax = true;
                //Go through list of names until blank and add person there
                for(int i=0; i<MAX_PEOPLE; i++){
                    //Get current name
                    currentName = order[i].getName();
                    //If you hit a empty spot, add that name and order in there
                    if(currentName.equals("")){
                        order[i].setName(name);
                        order[i].setTotal(price);
                        hitMax = false;
                        break;
                    }
                }
            }
        }
        
        //If max people is hit, alert user
        if(hitMax)
            message = "You have hit the max number\nof people per table. Order not added.";
        
        //Show message
        messageWindow(message);

    }
    
    //Get item price
    public static double getItemPrice(int itemNum, MenuItem[] menuArray) {
        //Get the menu item from the array
        MenuItem item = menuArray[itemNum+1];
        
        //Returnt he item's price
        return item.getPrice();
    }
    
    //Calculate bill
    public static void calculateBill(PersonOrder[] orders, double total){
        //Go through each item to get the total
        for(int i=0; i<MAX_PEOPLE; i++){
            total = total + orders[i].getTotal();
        }
    }
    
    //Print the order details on the screen
    public static void printOrderDetails(VBox box, PersonOrder[] orders, double total, double tip){
        //Declare string to hold order details
        String header = String.format("%-40s\t%-15s\t%-15s\t%-15s\t%-15s%n", "Name", "Meal", "Tax", "Tip", "Total");
        String summary = "";
        String footer, mealString, taxString, tipString, totalString, totalMeal, totalTax, totalTip, billTotal;
        
        //Meal, tax and tip amount variable
        double mealAmount = 0.0;
        double taxAmount = 0.0;
        double tipAmount = 0.0;
        double personTotal = 0.0;
        double mealTotal = 0.0;
        double taxTotal = 0.0;
        double tipTotal = 0.0;
        double totalBill = 0.0;
        
        //Go through each item and add details the the summary
        for(int i=0; i<MAX_PEOPLE; i++){
            //If there is person info there, calculate totals and add to summary string
            if(orders[i].getName()!=""){
                //Get each person's bill amounts
                mealAmount = orders[i].getTotal();
                taxAmount = SALES_TAX * mealAmount;
                tipAmount = tip * mealAmount;
                personTotal = taxAmount + tipAmount + mealAmount;
                //Format those amounts as strings
                mealString = String.format("%.2f", mealAmount);
                taxString = String.format("%.2f", taxAmount);
                tipString = String.format("%.2f", tipAmount);
                totalString = String.format("%.2f", personTotal);
                //Calculate total bill totals
                mealTotal += mealAmount;
                taxTotal += taxAmount;
                tipTotal += tipAmount;
                totalBill += personTotal;                
                //Add the individual's totals to the summary string
                summary += String.format("%-40s\t%-15s\t%-15s\t%-15s\t%-15s%n", orders[i].getName(), ("$" + mealString), ("$" + taxString), ("$" + tipString), ("$" + totalString));
            }
        }
        
        //Format the bill totals
        totalMeal = String.format("%.2f", mealTotal);
        totalTax = String.format("%.2f", taxTotal);
        totalTip = String.format("%.2f", tipTotal);
        billTotal = String.format("%.2f", totalBill);
        
        //Add total bill totals to string
        footer = String.format("%n%-40s\t%-15s\t%-15s\t%-15s\t%-15s%n", "Bill Total", ("$" + totalMeal), ("$" + totalTax), ("$" + totalTip), ("$" + billTotal));
        
        //Header
        Text headerText = new Text(header);
        headerText.setStyle("-fx-font-weight:bold;");
        box.getChildren().add(headerText);
        
        //Order summary label
        Text orderSummary = new Text(summary);
        box.getChildren().add(orderSummary);
        
        //Totals footer
        Text footerText = new Text(footer);
        footerText.setStyle("-fx-font-weight:bold;");
        box.getChildren().add(footerText);
    }
    
    //Show popup message in new stage
    public static void messageWindow(String message){
        //Show success message in a new stage window
        Stage stage = new Stage();
        //Create label
        Label added = new Label(message);
        added.setStyle("-fx-padding: 10px; -fx-font-family:tahoma; -fx-text-fill: darkBlue;");
        //Create button
        Button confirm = new Button("OK");        
        confirm.setStyle("-fx-font-family:tahoma; -fx-color: blue; -fx-text-fill: white;");
        //Create border pane
        BorderPane newPane = new BorderPane();
        //Add label to top
        newPane.setTop(added);
        //Add button to center
        newPane.setCenter(confirm);
        //Style the pane
        newPane.setStyle("-fx-background-color:#f1f5a9");
        //Create new scene with the newPane in it
        Scene scene = new Scene(newPane, 270, 100);
        //Add the scene to the stage
        stage.setScene(scene);
        //Give the stage a title
        stage.setTitle("Waiter Helper Alert");
        //Show the stage
        stage.show();
        //Hide the stage when the button is pressed
        confirm.setOnAction(new EventHandler<ActionEvent>() {
           public void handle(ActionEvent e) {
               stage.hide();
           } 
        });
    }
}

//Class for menu items
class MenuItem {
    String name;
    double price;
    int itemNum;
    
    //Default constructor
    MenuItem() {
        name="";
        price = 0.0;
        itemNum = 0;
    }
    
    //Constructor with name, price, and item number included
    MenuItem(String mName, double mPrice, int mNum) {
        name = mName;
        price = mPrice;
        itemNum = mNum;
    }
    
    //Get name of item
    String getName() {
        return name;
    }
    
    //Get price of item
    double getPrice() {
        return price;
    }
    
    //Get item number
    int getItemNum() {
        return itemNum;
    }
    
    //Set name of item
    void setName(String mName) {
        name = mName;
    }
    
    //Set price of item
    void setPrice(double mPrice) {
        price = mPrice;
    }
    
    //Set item number
    void setItemNum(int mNum) {
        itemNum = mNum;
    }
}

//Class to hold each person's order total
class PersonOrder {
    String name;
    double total;
    
    //Default constructor
    PersonOrder() {
        name = "";
        total = 0.0;
    }
    
    //Constructor with name and original item price
    PersonOrder(String oName, double oPrice) {
        name = oName;
        total = oPrice;
    }
    
    //Add item to person's total
    void addItem(double iPrice) {
        total = total + iPrice;
    }
    
    //Get name
    String getName() {
        return name;
    }
    
    //Get total
    double getTotal() {
        return total;
    }
    
    //Set name
    void setName(String oName) {
        name = oName;
    }
    
    //Set total
    void setTotal(double oTotal) {
        total = oTotal;
    }
}