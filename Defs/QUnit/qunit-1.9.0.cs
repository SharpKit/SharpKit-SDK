using SharpKit.JavaScript;

//[assembly:JsNamespace("SharpKit.QUnit"
namespace SharpKit.QUnit
{
    [JsType(JsMode.Global, Export = false)]
    public class Assert
    {
        /// <summary>
        /// A deep recursive comparison assertion, working on primitive types, arrays, objects, regular expressions, dates and functions.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        /// <remarks>
        /// deepEqual( actual: Object, expected: Object, message: String )
        /// The deepEqual() assertion can be used just like equal() when comparing the value of objects, such that { key: value } is equal to { key: value }. For non-scalar values, identity will be disregarded by deepEqual.
        /// notDeepEqual() can be used to explicitly test deep, strict inequality.
        /// </remarks>
        public static void deepEqual(object actual, object expected, JsString message) { }

        /// <summary>
        /// A comparison assertion, equivalent to JUnit/CommonJS assertEqual(s).
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        ///<remarks>
        ///equal( actual: String,Number,Boolean, expected: String,Number,Boolean, message: String )
        ///The equal assertion uses the simple comparison operator (==) to compare the actual and expected arguments. When they are equal, the assertion passes; otherwise, it fails. When it fails, both actual and expected values are displayed in the test result, in addition to a given message.
        ///notEqual() can be used to explicitly test inequality.
        /// </remarks>
        public static void equal(JsString actual, JsString expected, JsString message) { }
        /// <summary>
        /// A comparison assertion, equivalent to JUnit/CommonJS assertEqual(s).
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        ///<remarks>
        ///equal( actual: String,Number,Boolean, expected: String,Number,Boolean, message: String )
        ///The equal assertion uses the simple comparison operator (==) to compare the actual and expected arguments. When they are equal, the assertion passes; otherwise, it fails. When it fails, both actual and expected values are displayed in the test result, in addition to a given message.
        ///notEqual() can be used to explicitly test inequality.
        /// </remarks>
        public static void equal(JsNumber actual, JsNumber expected, JsString message) { }
        /// <summary>
        /// A comparison assertion, equivalent to JUnit/CommonJS assertEqual(s).
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        ///<remarks>
        ///equal( actual: String,Number,Boolean, expected: String,Number,Boolean, message: String )
        ///The equal assertion uses the simple comparison operator (==) to compare the actual and expected arguments. When they are equal, the assertion passes; otherwise, it fails. When it fails, both actual and expected values are displayed in the test result, in addition to a given message.
        ///notEqual() can be used to explicitly test inequality.
        /// </remarks>
        public static void equal(bool actual, bool expected, JsString message) { }

        /// <summary>
        /// A boolean assertion, equivalent to CommonJS’s assert.ok() and JUnit’s assertTrue(). Passes if the first argument is truthy.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="message"></param>
        ///<remarks>
        ///ok( state: Expression, message: String )
        ///The most basic assertion in QUnit, ok() requires just one argument. If the argument evaluates to true, the assertion passes; otherwise, it fails.
        ///If a second message argument is provided, it will be displayed in place of the result.
        /// </remarks>
        public static void ok(bool state, JsString message) { }

        /// <summary>
        /// A strict type and value comparison assertion.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        /// <remarks>
        /// strictEqual( actual: String,Number,Boolean, expected: String,Number,Boolean, message: String )
        /// The strictEqual() assertion provides the most rigid comparison of type and value with the strict equality operator (===.
        /// notStrictEqual() can be used to explicitly test strict inequality.
        /// </remarks>
        public static void strictEqual(JsString actual, JsString expected, JsString message) { }
        /// <summary>
        /// A strict type and value comparison assertion.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        /// <remarks>
        /// strictEqual( actual: String,Number,Boolean, expected: String,Number,Boolean, message: String )
        /// The strictEqual() assertion provides the most rigid comparison of type and value with the strict equality operator (===.
        /// notStrictEqual() can be used to explicitly test strict inequality.
        /// </remarks>
        public static void strictEqual(JsNumber actual, JsNumber expected, JsString message) { }
        /// <summary>
        /// A strict type and value comparison assertion.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        /// <remarks>
        /// strictEqual( actual: String,Number,Boolean, expected: String,Number,Boolean, message: String )
        /// The strictEqual() assertion provides the most rigid comparison of type and value with the strict equality operator (===.
        /// notStrictEqual() can be used to explicitly test strict inequality.
        /// </remarks>
        public static void strictEqual(bool actual, bool expected, JsString message) { }

        /// <summary>
        /// Assertion to test if a callback throws an exception when run.
        /// </summary>
        /// <param name="block"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        /// <remarks>
        /// throws( block: Function(), expected: Error, message: String )
        /// When testing code that is expected to throw an exception based on a specific set of circumstances, use throws() to catch the error object for testing and comparison.
        /// </remarks>
        public static void throws(JsAction block, JsError expected, JsString message) { }

    }

    [JsType(JsMode.Global, Export = false)]
    public class AsyncControl
    {

        /// <summary>
        /// Start running tests again after the testrunner was stopped. See stop().
        /// </summary>
        /// <param name="decrement"></param>
        /// <remarks>
        /// start( decrement: Number )
        /// When your async test has multiple exit points, call start() for the corresponding number of stop() increments.
        /// </remarks>
        public static void start(JsNumber decrement) { }
        /// <summary>
        /// Start running tests again after the testrunner was stopped. See stop().
        /// </summary>
        /// <remarks>
        /// start( decrement: Number )
        /// When your async test has multiple exit points, call start() for the corresponding number of stop() increments.
        /// </remarks>
        public static void start() { }

        /// <summary>
        /// Stop the testrunner to wait for async tests to run. Call start() to continue.
        /// </summary>
        /// <param name="increment"></param>
        /// <remarks>
        /// stop( [increment: Integer ] )
        /// When your async test has multiple exit points, call stop() with the increment argument, corresponding to the number of start() calls you need.
        /// On Blackberry 5.0, window.stop is a native read-only function. If you deal with that browser, use QUnit.stop() instead, which will work anywhere.
        /// </remarks>
        public static void stop(JsNumber increment) { }
        /// <summary>
        /// Stop the testrunner to wait for async tests to run. Call start() to continue.
        /// </summary>
        /// <remarks>
        /// stop( [increment: Integer ] )
        /// When your async test has multiple exit points, call stop() with the increment argument, corresponding to the number of start() calls you need.
        /// On Blackberry 5.0, window.stop is a native read-only function. If you deal with that browser, use QUnit.stop() instead, which will work anywhere.
        /// </remarks>
        public static void stop() { }

    }

    [JsType(JsMode.Global, Export = false)]
    public class QUnit
    {
        public QUnit(QUnitConfiguration cofig) { }

        public QUnit() { }

        /// <summary>
        /// Register a callback to fired when the test suite begins.
        /// </summary>
        /// <param name="callback"></param>
        /// <remarks>
        /// QUnit.begin( callback: Function() )
        /// QUnit.begin() is called once before running any tests. (a better would’ve been QUnit.start, but thats already in use elsewhere and can’t be changed.)
        /// </remarks>
        public static void begin(JsAction callback) { }

        /// <summary>
        /// Register a callback to fired when the test suite ends.
        /// </summary>
        /// <param name="callback"></param>
        /// <remarks>
        /// QUnit.done( callback: Function(details: Object) )
        /// QUnit.done() is called whenever all the tests have finished running. failed is the number of failures that occurred. total is the total number of assertions that occurred, passed the passing assertions. runtime is the time in milliseconds to run the tests from start to finish.
        /// </remarks>
        public static void done(JsAction<DoneDetailsOptions> callback) { }
        //TODO: CHECK

        /// <summary>
        /// Register a callback to fire whenever an assertion completes.
        /// </summary>
        /// <param name="callback"></param>
        /// <remarks>
        /// QUnit.log( callback: Function(details: Object) )
        /// This is one of several callbacks QUnit provides. Its intended for integration scenarios like PhantomJS or Jenkins.
        /// The properties of the details argument are listed below as options.
        /// </remarks>
        public static void log(JsAction<LogDetailsOptions> callback) { }
        //TODO: CHECK

        /// <summary>
        /// Register a callback to fired whenever a module ends.
        /// </summary>
        /// <param name="callback"></param>
        public static void moduleDone(JsAction callback) { }

        /// <summary>
        /// Register a callback to fired whenever a module begins.
        /// </summary>
        /// <param name="callback"></param>
        public static void moduleStart(JsAction callback) { }

        /// <summary>
        /// Register a callback to fired whenever a test block ends.
        /// </summary>
        /// <param name="callback"></param>
        public static void testDone(JsAction callback) { }

        /// <summary>
        /// Register a callback to fired whenever a test block begins.
        /// </summary>
        /// <param name="callback"></param>
        public static void testStart(JsAction callback) { }
    }
   //TODO: not sure the callback needs to be here.+ check constractor

    /// <summary>
    /// Configuration for QUnit
    /// </summary>
    /// <remarks>
    /// QUnit has a bunch of internal configuration defaults, some of which are useful to override. Check the description for each option for details.
    /// </remarks>
    [JsType(JsMode.Global, Export = false)]
    public class QUnitConfiguration
    {
        /// <summary>
        /// Default: true
        /// By default, QUnit will run tests first that failed on a previous run. In a large testsuite, this can speed up testing a lot.
        /// It can also lead to random erros, in case your testsuite has non-atomic tests, where the order is important. You should fix those issues, instead of disabling reordering!
        /// </summary>
        public bool reorder { get; set; }

        /// <summary>
        /// Default: true
        /// By default, QUnit updates document.title to add a checkmark or x-mark to indicate if a testsuite passed or failed. This makes it easy to see a suites result even without looking at a tab’s content.
        /// If you’re dealing with code that tests document.title changes or have some other problem with this feature, set this option to false to disable it.
        /// </summary>
        public bool altertitle { get; set; }

        /// <summary>
        /// Default: false
        /// The expect() method is optional by default, though it can be useful to require each test to specify the number of expected assertions.
        /// Enabling this option will cause tests to fail, if they don’t call expect() at all.
        /// </summary>
        public bool requireExpects { get; set; }

        /// <summary>
        /// This property controls which checkboxes to put into the QUnit toolbar element (below the header). By default, the “noglobals” and “notrycatch” checkboxes are there. By extending this array, you can add your own checkboxes.
        /// Each element should have three properties: id will be used as the config and query-string key, label will be used as the display propery (text in the UI), tooltip will be used as the title attribute, and should explain what the checkbox does.
        /// </summary>
        public JsArray urlConfig { get; set; }


    }

    [JsType(JsMode.Global, Export = false)]
    public class DoneDetailsOptions
    {
        /// <summary>
        /// The number of failures that occurred.
        /// </summary>
        public JsNumber failed { get; set; }

        /// <summary>
        /// The number of tests that passed assertions.
        /// </summary>
        public JsNumber passed { get; set; }

        /// <summary>
        /// The total number of assertions that occurred.
        /// </summary>
        public JsNumber total { get; set; }

        /// <summary>
        /// The time in milliseconds it took tests to run from start to finish.
        /// </summary>
        public JsNumber runtime { get; set; }
    }

    [JsType(JsMode.Global, Export = false)]
    public class LogDetailsOptions
    {
        /// <summary>
        /// The boolean result of an assertion, true means passed, false means failed.
        /// </summary>
        public bool result { get; set; }

        /// <summary>
        /// One side of a comparision assertion. Can be undefined when ok() is used.
        /// </summary>
        public object actual { get; set; }

        /// <summary>
        /// One side of a comparision assertion. Can be undefined when ok() is used.
        /// </summary>
        public object expected { get; set; }

        /// <summary>
        /// A string description provided by the assertion.
        /// </summary>
        public JsString message { get; set; }
    }

    [JsType(JsMode.Global, Export = false)]
    public class Test
    {
        /// <summary>
        /// Add an asynchronous test to run. The test must include a call to start().
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expected"></param>
        /// <param name="test"></param>
        /// <remarks>
        /// asyncTest( name: String, expected: Number, test: Function() )
        /// For testing asynchronous code, asyncTest will automatically stop the test runner and wait for your code to call start() to continue.
        /// </remarks>
        public static void asyncTest(JsString name, JsNumber expected, JsAction test) { }

        /// <summary>
        /// Specify how many assertions are expected to run within a test.
        /// </summary>
        /// <param name="amount"></param>
        /// <remarks>
        /// To ensure that an explicit number of assertions are run within any test, use expect( number ) to register an expected count.
        /// If the number of assertions run does not match the expected count, the test will fail.
        /// </remarks>
        public static void expect(JsNumber amount) { }

        /// <summary>
        /// Separate tests into modules.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lifecycle"></param>
        /// <remarks>
        /// All tests that occur after a call to module() will be grouped into that module.
        /// The test names will all be preceded by the module name in the test results. You can then use that module name to select tests to run.
        /// </remarks>
        public static void module(JsString name, object lifecycle) { }

        /// <summary>
        /// Add a test to run.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="expected"></param>
        /// <param name="test"></param>
        /// <remarks>
        /// test( title: String[, expected: Number ], test: Function(assert: QUnit.assert) )
        /// When testing the most common, synchronous code, use test()
        /// The assert argument to the callback contains all of QUnit’s assertion methods. If you are avoiding using any of QUnit’s globals, you can use the assert argument instead.
        /// </remarks>
        public static void test(JsString title, JsNumber expected, JsAction<Assert> test) { }
        /// <summary>
        /// Add a test to run.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="test"></param>
        /// <remarks>
        /// test( title: String[, expected: Number ], test: Function(assert: QUnit.assert) )
        /// When testing the most common, synchronous code, use test()
        /// The assert argument to the callback contains all of QUnit’s assertion methods. If you are avoiding using any of QUnit’s globals, you can use the assert argument instead.
        /// </remarks>
        public static void test(JsString title, JsAction<Assert> test) { }
    }
}
