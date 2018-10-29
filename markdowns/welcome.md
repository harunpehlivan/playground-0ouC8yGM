# Welcome!

The Breadth First Search algorithm is based on a queue, a data collection where the First In element is the First Out at reading to search in a tree. Collection size is unlimited, making the algorithm running slower.

The Beam Search is also a tree search algorithm but the data are sorted using a score fonction and the collection has a maximum size. The algorithm is very fast but the result are not always guaranteed and not optimal.

The source code is on [GitHub](https://github.com/TechDotIO/csharp-template), please feel free to come up with proposals to improve it.

## Run the Demo

@[Comparison between Breadth First Search and Beam Search]({"stubs": ["Exercises/UniverseStub.cs"],"command": "TechIo.UniverseTest.comparisonBFS_BMS"})

### More Resources 

[`Breadth First Search pseudo algorithm`](https://en.wikipedia.org/wiki/Breadth-first_search#Pseudocode)

[`Beam Search pseudo algorithm`](http://jhave.org/algorithms/graphs/beamsearch/beamsearch.shtml)
