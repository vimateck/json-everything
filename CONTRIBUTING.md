# Community Engagement

Questions, suggestions, corrections.  All are welcome.

Channels for community engagement (where I'll be looking) include:

- Issues
- Slack (link in the README)
- StackOverflow (tag with `json-everything`)

## Submitting Issues

Please be sure that you've read the [documentation](https://docs.json-everything.net) and that you're using the library correctly.  It sounds silly, but these kinds of issues are actually quite common.

For bugs, please submit _minimal_ reproductions that demonstrate the problem you're reporting.  Do not send me your production code and expect me to debug it for you.  While testing can never cover every case, these libraries are very thoroughly tested using public suites supplemented by my own test cases.  As such I'm _very_ confident that the libraries adhere to their respective specifications.

## Submitting PRs

Please be sure that an issue has been opened to allow for proper discussion before submitting a PR.  If the project maintainers decide _not_ to merge your PR, you might feel you've wasted your time, and no one wants that.

# Development

## Requirements

These libraries run tests in .Net 6 and .Net 8, so you'll need those.

All of the projects are configured to use the latest C# version.

## IDE

I use Visual Studio Community with Resharper, and I try to keep everything updated.

Jetbrains Rider (comes with the Resharper stuff built-in), VS Code with your favorite extensions, or any basic text editor and a command line would work just fine.  You do you.

## Running Tests

The tests can be run with any runner.  They do have quite a lot of output, which caused some problems with the results analyzer in the server build.

To address this, the test output has been disabled, but it can be re-enabled locally by setting the `JSON_EVERYTHING_TEST_OUTPUT` environment variable to "True".

## Code Style & Releases

Whie I do have an `.editorconfig` that most editors should respect, please feel free to add any code contributions using your own coding style.  Trying to conform to someone else's style can be a headache and confusing, and I prefer working code over pretty code.  I find it's easier for contributors if I make my own style adjustments after a contribution rather than forcing conformance to my preferences.

Deployments to Nuget and [json-everything.net](https://json-everything.net) occur automatically upon merging with `master`, so I usually create a secondary branch where I can first make any adjustments, including updating package versions and release notes.

For these reasons, you can expect your PRs to be retargeted to a branch other than `master`.

## What Needs Doing?

Anything in the [issues](https://github.com/json-everything/json-everything/issues?q=is%3Aopen+is%3Aissue+label%3A%22help+wanted%22) with a `help wanted` label is something that could benefit from a volunteer or two.

Of primary focus is translating the [resource file](https://github.com/json-everything/json-everything/blob/master/src/JsonSchema/Localization/Resources.resx) into additional languages for _JsonSchema.Net_.

Outside of this, PRs are welcome.  As mentioned above, for larger changes or changes to the API surface, it's preferred that there be some discussion in an issue before a PR is submitted.  Mainly, I don't want you to feel like you've wasted your time if changes are requested or the PR is ultimately closed unmerged.
