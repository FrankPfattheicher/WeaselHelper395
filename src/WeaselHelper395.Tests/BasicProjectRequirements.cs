using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaselHelper395.EnterpriseFeeling;

namespace WeaselHelper395.Tests
{
    [TestClass]
    public class BasicProjectRequirements
    {

        /// <summary>
        /// Let me take the opportunity to educate you on what makes a good test in a proper
        /// OO design. We applied this method together with ThoughtWorks in Heidelberg a couple
        /// of years ago. While at the start, these things might take some getting used to,
        /// in the end, they will all make sense, so bear with me. 
        /// 
        /// Step 1.: Use Test Step Labels
        /// -----------------------------
        /// 
        /// Common labels are:
        ///         Arrange, Act, Assert
        ///     
        ///     or
        ///         Given, When, Then
        ///         
        ///     or
        ///         Setup, Exercise, Verify
        ///     
        ///     or 
        ///         Eingabe, Verarbeitung, Ausgabe
        ///     
        /// More here:
        /// https://www.amazon.de/xUnit-Test-Patterns-Refactoring-Signature/dp/0131495054
        /// 
        /// Reasoning: 
        ///     Each test should be phrased as Input-Processing-Output (following the EVA principle).
        ///     Placing the labels, helps you identify these setps. If one of the steps is missing
        ///     there might be something odd with your code. 
        ///     
        ///     You should try to write your test that way, because simple code will fit nicely.
        ///     More often then not, however, the code will NOT fit nicely into this structure. 
        ///     But rather than just not putting the labels in, because they don't fit,
        ///     you should reason about what you could do to make your code fit.
        ///     
        ///     If your code does not adhere to these labels, you might be doing something odd.
        ///     The labels tell you that. 
        ///         
        ///     This idea is called: Listening to your tests.
        /// </summary>
        [TestMethod]    
        public void ShouldHaveEnterpriseFeeling()
        {
            // Arrange
                // In the arrange step, you setup all direct inputs.
                // You will also setup all dependent on components. 


            // System under Test
                // Use this label as well. In Object oriented code, 
                // you should always have an object. If you don't, for example
                // when you are using static functions, then your code will end up
                // procedural, not object oriented. The tests are trying to tell you that. 


                // This here is actually really important. The constructor call is being made
                // WITHIN the test. Often, this will become very painfull, for example,
                // when the constructor has tons of dependencies, and needs many other objects
                // to work. 
                // But again: LISTEN to your tests. If making a CTOR call here is too difficult for you
                // there might be something wrong with yout code. Maybe the object is doing too much
                // Maybe the setup is too complicated.
                // 
                // The name of the Ctor here is also important: You can tell the it is unclear, what this
                // Thing is supposed to do. 
                // 
                // It is important not to call the object "SUT". This is the meta vocabulary
                // You should name the object after its role in the world and in the application
                // SUT labels the object after its role in the test. And you don't really care about 
                // that. The test is a means to an end. 
            
            var adapter = new AbstractServiceHelperFactoryGeneratorMiddelwarePoolAdapter();

            // Act
                // The act label is to call the method. You should only test direct effects 
                // (so when you put A in, you should get B, but not B').
                // You should always test for behavior, never for state. 


            // Assert
                // In the assert step, you test whether your direct inputs have actually caused
                // An immediate effect. You test for direct outputs, not for indirect outputs. 
                // Indirect outputs are, for example, writing to a database or to a file.
                // These are sideeffects. You should test those things somewhere else. 
                // Your units should all be modeled to cause immediate effects. 
                // 
                // Listen to the functional programming guys. They have been trying to tell you
                // that for ages. Testing stuff that does not have side effects is super easy
                // 
                // The following is crap. You don't care about whether this thing exists.
                // You would, however care about its behavior. 
                // Testing null for the result of the adapter's operation 
                // is important
            Assert.IsNotNull(adapter);
        }

        // Listen to your tests.
        // Do this: 
        // Place the four label comments:
        //  // Arrange
        //  // System under Test
        //  // Act
        //  // Assert
        // 
        // Fill in the template. You should have something to setup.
        // You have a SUT. This can be a function or object.
        // Make it do something. Check the output.
        // Ideally, each of those things should be one line. 
        // Make sure to make the constructor call.
        // It is a common pattern to create a single object for the whole fixture,
        // And each test method tests one of the central SUT's methods
        // DON'T DO THAT. You wan't to see the CTOR call. 
        // If making a CTOR call is annoying, don't hide it away. 
        // Decompose the object into smaller units. 
        //
        // 1. Do make an explicit ctor call
        // 2. Acting should be one line 
        // 3. Acting actually means calling a method. Don't inspect state. 
        // 4. A property is not a method (technically, it is, but not conceptually)
        // 5. Asserting should be one line. Do not inspect internals, only inspect results
        // 6. Assert what the result _is_ - Equals. Avoid too detailed assertions, and complex stuff such as sequence equals, or greaterThan etc.
        //    Complex asserts will make refactoring difficult
        // 6.1. If your result is a list, don't check what's in it. Check its length at most.
        //      You shouldn't return lists or enumerables anyway. Return an domain specific object, ffs, that's what they are for.
    }
}
