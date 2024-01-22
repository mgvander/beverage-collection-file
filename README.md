# Assignment 1 - Review of C# Basic Concepts and Introduction to Git

## Author

Michael VanderMyde

## Description

Create a C# console program to work with a .CSV beverage list. The program should continually run until the user decides to exit (entering a certain character on the keyboard). The program should allow the following functionality:

1. Display a menu for the user to interact with. Re-display the menu where appropriate. Don't assume the user will know what to do next.
2. Allow the user to populate the beverage collection from the provided CSV file. They should only be able to load the file once.
3. Allow the user to print the entire list of beverages in the beverage collection.
4. Allow the user to search for a beverage by the beverage id, and print out the details of the beverage if found. Error message if not. (Linear search is fine)
5. Allow the user to add a new beverage to the beverage collection. Ensure that the id is unique and can not be duplicated when adding a new beverage item.

Here is a Sample Menu:
  1. Load File
  2. Print List
  3. Search List
  4. Add New Beverage
  5. Exit

Create a class called Beverage.
The id, name, and pack should be strings, price should be a decimal, and active should be a bool.
This class should have the following variables, properties, constructors, methods, etc.
* Variables: id, name, pack, price, active
* Constructors: 5 parameter constructor
* Public Methods: ToString (Override) - Used to convert an instance of Beverage to a String containing all the properties of the beverage in a readable format.
* Private Methods: Your choice

Create a class called BeverageCollection.
The purpose of this class is to act as a 'wrapper' class for the array. This means that it should contain an array of type Beverage to hold all of the Beverages, and provide public methods to interact with the array. EX: Add, Search, ToString. See below for more info on ToString. Rather than the rest of your assignment interacting with an array directly, it will call methods on this class, who's sole purpose, will be to interact with the array. The size of the array defined and used inside the collection can be a fixed size large enough to accommodate the data. Don't worry about using the data to determine the array size. Just pick a size large enough to handle the data.

The ToString method for this class will be used to convert the entire collection to a string. This means that it will need to iterate over all of the Beverages in the underlying array and convert each one to a string that get concatenated to a collection string that can be returned for displaying in the console.

ToString for a Beverage class converts a single Beverage to a string that can be output.
ToString for the BeverageCollection class converts all Beverages stored in the collection to a string that can be output.

If you have questions about this class, ask.

This class should have the following variables, properties, constructors, methods, etc.
* Variables: beverages (Array of type Beverage. It must be an array. No List)
* Constructors: Your choice
* Public Methods: Add, Search, ToString
* Private Methods: Your choice

Create a class called User Interface. This class should be implemented however you see fit. It should handle all of the Screen input and output for the program. (With the possible exception of 'exception messages caused by a catch in a try/catch'). Since most exceptions occur when the program does something unexpected, it is okay if you do not send exception error messages to the UI class. You can if you would like, but are not required to.
There is a good chance that you will want a more sophisticated UI with more methods than what you saw in the in-class. The in-class version was VERY minimalistic. Your assignment UI class should have more output methods that can do more work than just outputting a single line. EX: PrintHeader(), GetBeverageId(), PrintList(), etc.

This class should have the following variables, properties, constructors, methods, etc.
* Variables: Your choice
* Constructors: Your choice
* Public Methods: Your choice
* Private Methods: Your choice

Create a class called CSVProcessor. This class should be in charge of reading in a CSV file and adding records to the BeverageCollection. It may also want to handle ensuring the CSV can only be read in once. (By only loading once, you ensure new data is not overwritten, or the size of the array is exceeded. This criteria exists to save you time.)

NOTE: With the in-class, we send a raw array to the CSVProcessor class so that entries can be added to it. In the assignment, you should't use the array directly. We have a class for that. BeverageCollection. Is it possible to send an instance of BeverageCollection to CSVProcessor in place of a raw array?

This class should have the following variables, properties, constructors, methods, etc.
* Variables: Your choice
* Constructors: Your choice
* Public Methods: Your choice
* Private Methods: Your choice

Documentation should include the following for this, and all future assignments:
* Comments at the top of each file that you add source code to:
  * Your Name
  * Class
  * Date
* A comment at the top of each method describing what it does. I would highly suggest you use the /// (triple slash) method for the comment. If I forget to mention this in class, remind me.
* Comments in the rest of the code where it isn't obvious what is going on. (I prefer above the line comments vs at the end of the line because no one likes to horizontally scroll. But, either will work)

Things you do ***NOT*** need to worry about:

* Determining the size of the array from the amount of data in the CSV
* Save the data from the BeverageCollection back to the CSV file
* Update or Delete existing entries

Solution Requirements:

* 5 classes (Program, Beverage, BeverageCollection, CSVProcessor, UserInterface)
* A loop
* An control structure (if/then statement, switch statement)
* An array [contents will be type Beverage]
* At least one method/function. (The main method is not included in this count)

### Notes
Even though you are free to write this however you would like within the constraints laid out above in the requirements, try to follow the single responsibility principle. I would suggest that you should attempt to make the User Interface handle the UI, the Beverage and BeverageCollection handle representing the data, CSVProcessor handle obtaining the data from the file, and the Program/Main handle orchestrating all of it.

Try to send any dependencies (classes needed inside other classes) into a class via either a constructor, or a method rather than creating a new one inside the class. If possible make all of the new instances in Program main. This is less of a concern for the classes that are obviously related. It is fine for BeverageCollection to create a new Beverage instance since they are clearly related. The goal is to future proof the program. Think of what if cases such as the following:
* What if we wanted to change out the User Interface with a different one? How much work would need to be done to fix it?
* What if instead of reading from a CSV file we wanted to start reading from a database? How much work would need to be done to fix it?

Suggestion/Hints:

* How the user enters the information is your choice (i.e., one at a time, all at once, etc.). However, you should strive to make it user friendly.
* You might need multiple loops, methods, control structures – just depends on your design. However, you must have a least one of each.
* Remember to handle the case when the user has entered no information. You can print a simple message (i.e., “No data entered” or something else). It just needs to be obvious to the user that something has happened.
* Remember to handle (gracefully) cases where the user enters something incorrectly.

## Grading
| Feature                    | Points |
|----------------------------|--------|
| Load CSV                   | 10     |
| Load CSV Only Once         | 5      |
| Print List                 | 10     |
| Search                     | 10     |
| Add New Item               | 10     |
| ToString Override          | 10     |
| CSV Processor Class        | 5      |
| UserInterface Class        | 5      |
| Beverage Class             | 5      |
| BeverageCollection Class   | 5      |
| A Loop / Control Structure | 5      |
| A Method                   | 5      |
| Beverage Array             | 5      |
| Documentation              | 5      |
| Readme                     | 5      |
| **Total**                  | **100**|

## Outside Resources Used

None

## Known Problems, Issues, And/Or Errors in the Program

None

