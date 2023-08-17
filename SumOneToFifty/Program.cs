var sum = 0;

for (int idx = 1; idx <= 50; idx++) {

    if(idx % 5 == 1 && idx % 7 == 1) {
        continue;
    }
    sum = sum + idx;

    //if (idx % 5 == 0 || idx % 7 == 0) {
    //    sum = sum + idx;
    //}
}

Console.WriteLine($"Sum of numbers 1 to 50 evenly divisible by 5 or 7 is {sum}");