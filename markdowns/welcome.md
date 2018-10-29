# Welcome!

The Breadth First Search algorithm is based on a queue, a data collection where the First In element is the First Out at reading to search in a tree. Collection size may become unnecessarily large, making the algorithm running slower.

The Beam Search is also a tree search algorithm but the data are filtered and sorted using a score fonction and the collection has a limited size. The algorithm is very fast but the results are not always guaranteed or optimal.

Lets compare these algorithms walking between two cells in a maze.

The source code is on [GitHub](https://github.com/iadevoops/playground-0ouC8yGM), please feel free to come up with proposals to improve it.

## Run the Demo

@[Comparison between Breadth First Search and Beam Search]({"stubs": ["Exercises/SearchAlgoStub.cs"],"command": "TechIo.SearchAlgoTest.comparisonBFS_BMS"})

### More Resources 

[`Breadth First Search pseudo algorithm`](https://en.wikipedia.org/wiki/Breadth-first_search#Pseudocode)

[`Beam Search pseudo algorithm`](http://jhave.org/algorithms/graphs/beamsearch/beamsearch.shtml)
