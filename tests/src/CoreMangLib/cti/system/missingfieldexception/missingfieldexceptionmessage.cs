using System;
using System.IO;
/// <summary>
///Message
/// </summary>
public class MissingFieldExceptionMessage
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new MissingFieldException instance.");

        try
        {
            string expectString = "this is a error";
            //Create the application domain setup information.
            MissingFieldException myMissingFieldException = new MissingFieldException(expectString);
            if (myMissingFieldException.Message != expectString)
            {
                TestLibrary.TestFramework.LogError("001.1", "the MissingFieldException ctor error occurred,the message should be " + expectString);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: Create a new MissingFieldException instance,string is empty.");

        try
        {
            string expectString = string.Empty;
            //Create the application domain setup information.
            MissingFieldException myMissingFieldException = new MissingFieldException(expectString);
            if (myMissingFieldException.Message != expectString)
            {
                TestLibrary.TestFramework.LogError("002.1", "the MissingFieldException ctor error occurred.the message should be " + expectString);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
  
    #endregion

    #endregion

    public static int Main()
    {
        MissingFieldExceptionMessage test = new MissingFieldExceptionMessage();

        TestLibrary.TestFramework.BeginTestCase("MissingFieldExceptionMessage");

        if (test.RunTests())
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

}
