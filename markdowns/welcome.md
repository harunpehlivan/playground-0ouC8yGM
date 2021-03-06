# Welcome!

The Breadth First Search algorithm is based on a queue, a data collection where the First In element is the First Out at reading to search in a tree. Collection size may become unnecessarily large, making the algorithm running slower.

The Beam Search is also a tree search algorithm but the data are filtered and sorted using a heuristic and the collection has a limited size. The algorithm is very fast but the results are not always guaranteed or optimal.

Lets compare these algorithms walking between two cells in a maze.

The source code is on [GitHub](https://github.com/iadevoops/playground-0ouC8yGM), please feel free to come up with proposals to improve it.

## Run the Demo

@[Comparison between Breadth First Search and Beam Search]({"stubs": ["Exercises/SearchAlgoComparison.cs"],"command": "SearchAlgo.SearchAlgoTest.comparisonBFS_BMS"})

## Conclusion

A beam search algorithm is very easy to write an its a great optimization of the bfs. A bad choice for the score function cause to lose informations during filtering (or the pruning) operation. A lots of variation can be made respecting the beam search algorithm principle of using a heuristic to choose a limited size collection beam.

### More Resources 

[`Breadth First Search pseudo algorithm`](https://en.wikipedia.org/wiki/Breadth-first_search)

[`Beam Search pseudo algorithm`](https://en.wikibooks.org/wiki/Artificial_Intelligence/Search/Heuristic_search/Beam_search)
