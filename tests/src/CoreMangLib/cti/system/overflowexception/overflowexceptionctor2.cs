using System;
using System.Collections.Generic;
/// <summary>
///ctor(System.String) [v-junche]
/// </summary>
public class OverflowExceptionCtor2
{
    public static int Main()
    {
        OverflowExceptionCtor2 OverflowExceptionCtor2 = new OverflowExceptionCtor2();

        TestLibrary.TestFramework.BeginTestCase("OverflowExceptionCtor2");
        if (OverflowExceptionCtor2.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new instance of OverflowException.");
        try
        {
            string expectValue = "HELLO";
            OverflowException myException = new OverflowException(expectValue);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("001.1", "OverflowException instance can not create correctly.");
                retVal = false;
            }
            if (myException.Message != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.2", "the Message should return " + expectValue);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: the parameter string is null.");
        try
        {
            string expectValue = null;
            OverflowException myException = new OverflowException(expectValue);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("002.1", "OverflowException instance can not create correctly.");
                retVal = false;
            }
            if (myException.Message == expectValue)
            {
                TestLibrary.TestFramework.LogError("002.2", "the Message should return the default value.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}
