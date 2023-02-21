# Contributions to the workshop files
I'm thrilled that you want to contribute to the workshop files, thanks! 🥳

To make it easier for you to contribute I've added some notes about what to keep in mind when contributing to this repository.

## Bug and Feature requests
The best way to report a bug or feature request on this project is to use the issues panel in the repository. Please mark the ticket with either `[BUG]` or `[FEATURE REQUEST]` in the start of the title to make it easy for maintainers to catagorise what's submitted. It's always nice to check the existing reports to see if anyone else has the same bug or request as you. If that's the case then you should rather give that ticket a upvote and follow the ticket. This helps the maintaner prioritise the tickets, resulting in you geting your requested feature or bugfix implemented faster.  

## Pull requests
By default we squash changes on the main and completed banches to keep the Git-log clean, and then make sure that the squash commit includes the Pull request number so we can go back and see in more details. 

Always make sure that all tests and workflows passes whenever you've med a change. The most important thing with workshop files is that they actually work as intended for the end-users. Any changes that requires the end-user of this repository to run commands or have things installed for the files to run must be updated in the README.md of the relevant project. 

All pull requests on the application code should be opened against main, and then be rebased down to completed after merge. All changes regarding the devcontainer configs should be opened agains the completed branch.
