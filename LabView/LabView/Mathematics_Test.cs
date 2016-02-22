using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ME.LabView
{
  /// <summary>
  /// class containing unit tests for the mathematics class
  /// </summary>
  [TestClass]
  public class Mathematics_Test
  {
    /// <summary>
    /// class to be tested
    /// </summary>
    private Mathematics TestObject = new Mathematics();

    /// <summary>
    /// Testfunction for addition
    /// </summary>
    [TestMethod]
    public void Addition_Test()
    {
      #region 8Bit
      // valid positiv values
      sbyte Value1_8Bit = 25;
      sbyte Value2_8Bit = 14;
      sbyte Result_8Bit = TestObject.Addition(Value1_8Bit, Value2_8Bit);
      Assert.AreEqual(39, Result_8Bit, "Test: 8Bit valid postitiv values");

      // valid negativ values
      Value1_8Bit = -14;
      Value2_8Bit = -25;
      Result_8Bit = TestObject.Addition(Value1_8Bit, Value2_8Bit);
      Assert.AreEqual(-39, Result_8Bit, "Test: 8Bit valid negativ values");

      // valid combined values
      Value1_8Bit = 14;
      Value2_8Bit = -25;
      Result_8Bit = TestObject.Addition(Value1_8Bit, Value2_8Bit);
      Assert.AreEqual(-11, Result_8Bit, "Test: 8Bit valid combined values");

      // overflow upper limit
      Value1_8Bit = sbyte.MaxValue - 2;
      Value2_8Bit = 15;
      Result_8Bit = TestObject.Addition(Value1_8Bit, Value2_8Bit);
      Assert.AreEqual(sbyte.MaxValue, Result_8Bit, "Test: 8Bit upper limit overflow");

      // overflow lower limit
      Value1_8Bit = sbyte.MinValue + 2;
      Value2_8Bit = -15;
      Result_8Bit = TestObject.Addition(Value1_8Bit, Value2_8Bit);
      Assert.AreEqual(sbyte.MinValue, Result_8Bit, "Test: 8Bit lower limit overflow");
      #endregion

      #region 16Bit
      // valid positiv values
      short Value1_16Bit =  300;
      short Value2_16Bit =  25;
      short Result_16Bit = TestObject.Addition(Value1_16Bit, Value2_16Bit);
      Assert.AreEqual(325, Result_16Bit, "Test: 16Bit valid postitiv values");

      // valid negativ values
      Value1_16Bit = -300;
      Value2_16Bit = -25;
      Result_16Bit = TestObject.Addition(Value1_16Bit, Value2_16Bit);
      Assert.AreEqual(-325, Result_16Bit, "Test: 16Bit valid negativ values");

      // valid combined values
      Value1_16Bit = 300;
      Value2_16Bit = -25;
      Result_16Bit = TestObject.Addition(Value1_16Bit, Value2_16Bit);
      Assert.AreEqual(275, Result_16Bit, "Test: 16Bit valid combined values");

      // overflow upper limit
      Value1_16Bit = short.MaxValue - 2;
      Value2_16Bit = 15;
      Result_16Bit = TestObject.Addition(Value1_16Bit, Value2_16Bit);
      Assert.AreEqual(short.MaxValue, Result_16Bit, "Test: 16Bit upper limit overflow");

      // overflow lower limit
      Value1_16Bit = short.MinValue + 2;
      Value2_16Bit = -15;
      Result_16Bit = TestObject.Addition(Value1_16Bit, Value2_16Bit);
      Assert.AreEqual(short.MinValue, Result_16Bit, "Test: 16Bit lower limit overflow");
      #endregion

      #region 32Bit
      // valid positiv values
      int Value1_32Bit = 70000;
      int Value2_32Bit = 25;
      int Result_32Bit = TestObject.Addition(Value1_32Bit, Value2_32Bit);
      Assert.AreEqual(70025, Result_32Bit, "Test: 32Bit valid postitiv values");

      // valid negativ values
      Value1_32Bit = -70000;
      Value2_32Bit = -25;
      Result_32Bit = TestObject.Addition(Value1_32Bit, Value2_32Bit);
      Assert.AreEqual(-70025, Result_32Bit, "Test: 32Bit valid negativ values");

      // valid combined values
      Value1_32Bit = 70000;
      Value2_32Bit = -25;
      Result_32Bit = TestObject.Addition(Value1_32Bit, Value2_32Bit);
      Assert.AreEqual(69975, Result_32Bit, "Test: 32Bit valid combined values");

      // overflow upper limit
      Value1_32Bit = int.MaxValue - 2;
      Value2_32Bit = 15;
      Result_32Bit = TestObject.Addition(Value1_32Bit, Value2_32Bit);
      Assert.AreEqual(int.MaxValue, Result_32Bit, "Test: 32Bit upper limit overflow");

      // overflow lower limit
      Value1_32Bit = int.MinValue + 2;
      Value2_32Bit = -15;
      Result_32Bit = TestObject.Addition(Value1_32Bit, Value2_32Bit);
      Assert.AreEqual(int.MinValue, Result_32Bit, "Test: 32Bit lower limit overflow");
      #endregion

      #region 64Bit
      // valid positiv values
      long Value1_64Bit = 3000000000;
      long Value2_64Bit = 25;
      long Result_64Bit = TestObject.Addition(Value1_64Bit, Value2_64Bit);
      Assert.AreEqual(3000000025, Result_64Bit, "Test: 64Bit valid postitiv values");

      // valid negativ values
      Value1_64Bit = -3000000000;
      Value2_64Bit = -25;
      Result_64Bit = TestObject.Addition(Value1_64Bit, Value2_64Bit);
      Assert.AreEqual(-3000000025, Result_64Bit, "Test: 64Bit valid negativ values");

      // valid combined values
      Value1_64Bit = 3000000000;
      Value2_64Bit = -25;
      Result_64Bit = TestObject.Addition(Value1_64Bit, Value2_64Bit);
      Assert.AreEqual(2999999975, Result_64Bit, "Test: 64Bit valid combined values");

      // overflow upper limit
      Value1_64Bit = long.MaxValue - 2;
      Value2_64Bit = 15;
      Result_64Bit = TestObject.Addition(Value1_64Bit, Value2_64Bit);
      Assert.AreEqual(long.MaxValue, Result_64Bit, "Test: 64Bit upper limit overflow");

      // overflow lower limit
      Value1_64Bit = long.MinValue + 2;
      Value2_64Bit = -15;
      Result_64Bit = TestObject.Addition(Value1_64Bit, Value2_64Bit);
      Assert.AreEqual(long.MinValue, Result_64Bit, "Test: 64Bit lower limit overflow");
      #endregion

      #region Float
      // valid positiv values, accuracy 0.0001
      float Value1_Float = 3.45f;
      float Value2_Float = 2.13f;
      float Result_Float = TestObject.Addition(Value1_Float, Value2_Float);
      Assert.AreEqual(5.58f, Result_Float, 0.0001, "Test: Float valid postitiv values");

      // valid negativ values, accuracy 0.0001
      Value1_Float = -3.45f;
      Value2_Float = -2.13f;
      Result_Float = TestObject.Addition(Value1_Float, Value2_Float);
      Assert.AreEqual(-5.58f, Result_Float, 0.0001, "Test: Float valid negativ values");

      // valid combined values, accuracy 0.0001
      Value1_Float = 3.45f;
      Value2_Float = -2.13f;
      Result_Float = TestObject.Addition(Value1_Float, Value2_Float);
      Assert.AreEqual(1.32f, Result_Float, 0.0001, "Test: Float valid combined values");

      // overflow upper limit, accuracy 0.0001
      Value1_Float = float.MaxValue - 2;
      Value2_Float = 4.3f;
      Result_Float = TestObject.Addition(Value1_Float, Value2_Float);
      Assert.AreEqual(float.MaxValue, Result_Float, 0.0001, "Test: Float upper limit overflow");

      // overflow lower limit, accuracy 0.0001
      Value1_Float = float.MinValue + 2;
      Value2_Float = -4.3f;
      Result_Float = TestObject.Addition(Value1_Float, Value2_Float);
      Assert.AreEqual(float.MinValue, Result_Float, 0.0001, "Test: Float lower limit overflow");
      #endregion

      #region double
      // valid positiv values, accuracy 0.0001
      double Value1_Double = 3.45;
      double Value2_Double = 2.13;
      double Result_Double = TestObject.Addition(Value1_Double, Value2_Double);
      Assert.AreEqual(5.58, Result_Double, 0.0001, "Test: Double valid postitiv values");

      // valid negativ values, accuracy 0.0001
      Value1_Double = -3.45;
      Value2_Double = -2.13;
      Result_Double = TestObject.Addition(Value1_Double, Value2_Double);
      Assert.AreEqual(-5.58, Result_Double, 0.0001, "Test: Double valid negativ values");

      // valid combined values, accuracy 0.0001
      Value1_Double = 3.45;
      Value2_Double = -2.13;
      Result_Double = TestObject.Addition(Value1_Double, Value2_Double);
      Assert.AreEqual(1.32, Result_Double, 0.0001, "Test: Double valid combined values");

      // overflow upper limit, accuracy 0.0001
      Value1_Double = double.MaxValue - 2;
      Value2_Double = 4.3;
      Result_Double = TestObject.Addition(Value1_Double, Value2_Double);
      Assert.AreEqual(double.MaxValue, Result_Double, 0.0001, "Test: Double upper limit overflow");

      // overflow lower limit, accuracy 0.0001
      Value1_Double = double.MinValue + 2;
      Value2_Double = -4.3;
      Result_Double = TestObject.Addition(Value1_Double, Value2_Double);
      Assert.AreEqual(double.MinValue, Result_Double, 0.0001, "Test: Double lower limit overflow");
      #endregion
    }
  }
}
