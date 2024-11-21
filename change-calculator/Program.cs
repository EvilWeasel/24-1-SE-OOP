Console.WriteLine("Decimal Result for 4,70 €:");
var result1 = CalculateChangeDecimal(4.70m);
for (int i = 0; i < result1.Length; i++)
{
  Console.WriteLine($"Wert {result1[i][0]} wird {result1[i][1]} herausgegeben.");
}

Console.WriteLine("Float Result for 4,70 €:");
var result2 = CalculateChangeFloat(4.70f);
for (int i = 0; i < result2.Length; i++)
{
  Console.WriteLine($"Wert {result2[i][0]} wird {result2[i][1]} herausgegeben.");
}

static decimal[][] CalculateChangeDecimal(decimal change)
{
  // float[] coinsAndPapers = { 100, 50, 20, 10, 5, 2, 1, .5f, .2f, .1f, .05f, .02f, .01f };
  decimal[] coinsAndPapers = { 100, 50, 20, 10, 5, 2, 1, 0.5m, 0.2m, 0.1m, 0.05m, 0.02m, 0.01m };

  decimal[][] returnChange = new decimal[coinsAndPapers.Length][];
  /*
    // int[] ints = {1,2,3,4,5};
    // ints == ints[0]
    // ints[1] => int32 hat 4 bytes, also 1 x 4 bytes = 4 bytes offset
    // ints[2] => int32 hat 4 bytes, also 2 x 4 bytes = 8 bytes offset
  */
  int count = 0;
  foreach (var coin in coinsAndPapers)
  {
    var amount = (int)(change / coin);
    // int amount = (int)Math.Ceiling(change / coin);
    returnChange[count] = new decimal[] { coin, amount };
    count++;
    change -= amount * coin;
  }

  return returnChange;
}

static float[][] CalculateChangeFloat(float change)
{
  float[] coinsAndPapers = { 100, 50, 20, 10, 5, 2, 1, .5f, .2f, .1f, .05f, .02f, .01f };

  float[][] returnChange = new float[coinsAndPapers.Length][];
  /*
    // int[] ints = {1,2,3,4,5};
    // ints == ints[0]
    // ints[1] => int32 hat 4 bytes, also 1 x 4 bytes = 4 bytes offset
    // ints[2] => int32 hat 4 bytes, also 2 x 4 bytes = 8 bytes offset
  */
  int count = 0;
  foreach (var coin in coinsAndPapers)
  {
    var amount = (int)(change / coin);
    // int amount = (int)Math.Ceiling(change / coin);
    returnChange[count] = new float[] { coin, amount };
    count++;
    // change -= (float)Math.Round(amount * coin, 2);
    change = change - (amount * coin);
    change = (float)Math.Round(change, 2);
  }

  return returnChange;
}
