Feature: TMFeature

A short summary of the feature

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turnUp portal successfully
	When I navigate to time and material page
	And I create a new time and material record
	Then The record should be created successfully

Scenario Outline: Edit existing time and material record with valid details
	Given I logged into turnUp portal successfully
	When  I navigate to time and material page
	And  I update '<description>' on an existing time and material record
	Then the record should have been updated '<description>'

Examples: 
| description |
| Time        |
| Material    |
| EditedRecord |
