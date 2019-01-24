# citrusbyte

[First commit](https://github.com/zilloy/citrusbyte/commit/7e7241a81fc3487b76049968ec6ad314cfcaee2d) contains recursive implementation of the algorithm

Performance test showed that time complexity increased exponentially when number of elements was increased (for deep structures)

1000 elements - 00:00:00.0194165

5000 elements - 00:00:00.4333768

[This article](https://blogs.msdn.microsoft.com/wesdyer/2007/03/23/all-about-iterators/) explains possible performance problems with `yield return` operator

So the implementation has been changed to non recursive, please see [here](https://github.com/zilloy/citrusbyte/commit/120d1505917d9232f85821a11a22418a0e8edb3d)

Time complexity became linear 

1000 elements - 00:00:00.0020284

5000 elements - 00:00:00.0023037
