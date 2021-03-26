
# About

This project contains a really simple model of a storage for video information.

There is no "correct" or "wrong" implementation for this challenge, you should be encouraged to show off your 
- coding and documentation style
- known design patterns
- dotnet Core knowledge

# Challenge

## 1. Add an option to print out movies formatted on the console
- Currently, the output on the console is poor, only the IDs of the movies are printed out
- The enhanced output should contain at least Id, Title, Duration and VideoUri

## 2. Query the movies list
Print out results for the following queries
1. All movies that are longer than 30 minutes
2. All movies that are hosted on YouTube, ordered by title
3. Total runtime of all movies that have an IMDb ID

## 3. Modify the design of the program, so that it also supports episodes (of series)
- An episode has the following properties in common with movies: Id, Title, Duration, VideoUri
- An episode has the following properties that movies don't have: SeriesTitle, SeasonNumber
- The new design should be made in a way that it can be extended to new types of videos in the future (e.g. short clips, bonus material, etc.)

## 4. Support multiple types of storage
- Currently, the video information is stored in-memory, e.g. all information is lost when the program shuts down.
- Extend the program in a way, that multiple types of storage could be used (e.g. storage to database, to file system, etc.) in the future.
- It should be possible to easily switch the types of storage without rewriting the whole program.
- You are not required to actually implement a new type of storage in this step.

## 5. Add the possibility to store to file system
- Create a storage mechanism that saves the information to disk.
- Show that your solution can also load the information from disk when program is executed the next time.

## 6. Add an export component
- Create a mechanism to export a list of videos (movies and episodes) to an XLSX Excel file
- The exported XLSX file should contain the following columns: Id, Type (Movie or Episode), Title, Duration, VideoUri

# Hints

- You may change any existing code, add new projects, add other external libraries, NuGet packages, etc.
- Feel free to ask any questions that occur during the development.
