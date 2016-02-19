namespace ME.LabView
{
  /// <summary>
  /// class containing mathematic functions
  /// </summary>
  class Mathematics
  {
    #region Addition
    /// <summary>
    /// Added two 8Bit values
    /// </summary>
    /// <param name="summand1">first 8Bit value</param>
    /// <param name="summand2">second 8Bit value</param>
    /// <returns>result of addition </returns>
    public sbyte Addition(sbyte summand1, sbyte summand2)
    {
      // Check upper limit overflow
      if ((summand1 >= 0) && (summand2 >= 0))
      {
        // if overflow happens limit result to max valid value
        if ((sbyte.MaxValue - summand1) < summand2)
          return sbyte.MaxValue;
      }
      // check lower limit overflow
      else if ((summand1 < 0) && (summand2 < 0))
      { 
        // if overflow happens limit result to min valid value
        if ((sbyte.MinValue - summand1) > summand2)
            return sbyte.MinValue;
      }
    
      // no overflow, return result 
      return (sbyte)(summand1 + summand2);
    }

    /// <summary>
    /// Added two 16Bit values
    /// </summary>
    /// <param name="summand1">first 16Bit value</param>
    /// <param name="summand2">second 16Bit value</param>
    /// <returns>result of addition </returns>
    public short Addition(short summand1, short summand2)
    {
      // Check upper limit overflow
      if ((summand1 >= 0) && (summand2 >= 0))
      {
        // if overflow happens limit result to max valid value
        if ((short.MaxValue - summand1) < summand2)
          return short.MaxValue;
      }
      // check lower limit overflow
      else if ((summand1 < 0) && (summand2 < 0))
      {
        // if overflow happens limit result to min valid value
        if ((short.MinValue - summand1) > summand2)
          return short.MinValue;
      }

      // no overflow, return result 
      return (short)(summand1 + summand2);
    }

    /// <summary>
    /// Added two 32Bit values
    /// </summary>
    /// <param name="summand1">first 32bit value</param>
    /// <param name="summand2">second 32Bit value</param>
    /// <returns>result of addition </returns>
    public int Addition(int summand1, int summand2)
    {
      // Check upper limit overflow
      if ((summand1 >= 0) && (summand2 >= 0))
      {
        // if overflow happens limit result to max valid value
        if ((int.MaxValue - summand1) < summand2)
          return int.MaxValue;
      }
      // check lower limit overflow
      else if ((summand1 < 0) && (summand2 < 0))
      {
        // if overflow happens limit result to min valid value
        if ((int.MinValue - summand1) > summand2)
          return int.MinValue;
      }

      // no overflow, return result 
      return summand1 + summand2;
    }

    /// <summary>
    /// Added two 64Bit values
    /// </summary>
    /// <param name="summand1">first 64Bit value</param>
    /// <param name="summand2">second 64Bit value</param>
    /// <returns>result of addition </returns>
    public long Addition(long summand1, long summand2)
    {
      // Check upper limit overflow
      if ((summand1 >= 0) && (summand2 >= 0))
      {
        // if overflow happens limit result to max valid value
        if ((long.MaxValue - summand1) < summand2)
          return long.MaxValue;
      }
      // check lower limit overflow
      else if ((summand1 < 0) && (summand2 < 0))
      {
        // if overflow happens limit result to min valid value
        if ((long.MinValue - summand1) > summand2)
          return long.MinValue;
      }

      // no overflow, return result 
      return summand1 + summand2;
    }

    /// <summary>
    /// Added two float values
    /// </summary>
    /// <param name="summand1">first float value</param>
    /// <param name="summand2">second float value</param>
    /// <returns>result of addition </returns>
    public float Addition(float summand1, float summand2)
    {
      // Check upper limit overflow
      if ((summand1 >= 0) && (summand2 >= 0))
      {
        // if overflow happens limit result to max valid value
        if ((float.MaxValue - summand1) < summand2)
          return float.MaxValue;
      }
      // check lower limit overflow
      else if ((summand1 < 0) && (summand2 < 0))
      {
        // if overflow happens limit result to min valid value
        if ((float.MinValue - summand1) > summand2)
          return float.MinValue;
      }

      // no overflow, return result 
      return summand1 + summand2;
    }

    /// <summary>
    /// Added two double values
    /// </summary>
    /// <param name="summand1">first double value</param>
    /// <param name="summand2">second double value</param>
    /// <returns>result of addition </returns>
    public double Addition(double summand1, double summand2)
    {
      // Check upper limit overflow
      if ((summand1 >= 0) && (summand2 >= 0))
      {
        // if overflow happens limit result to max valid value
        if ((double.MaxValue - summand1) < summand2)
          return double.MaxValue;
      }
      // check lower limit overflow
      else if ((summand1 < 0) && (summand2 < 0))
      {
        // if overflow happens limit result to min valid value
        if ((double.MinValue - summand1) > summand2)
          return double.MinValue;
      }

      // no overflow, return result 
      return summand1 + summand2;
    }

    #endregion
  }
}
