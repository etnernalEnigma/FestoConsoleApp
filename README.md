## Task

Create a simple C# (.NET Framework or .NET core) or Java console application that retrieve and display some courses from the given SQLite database (enclosed in the zip file.)

Courses should be displayed as follow:
  * Courses should be sorted by `title`
  * The `title` and `type` of a course should be displayed

The application should have an optionnal argument that's allowing the user to filter on the course type `name`. For exemple: `MyApplication.exe "Exercise"`.

The output should be a simple list of courses like this:

```
Course Title 1 (Course Type Name)
Course Title 2 (Course Type Name)
...
```

### Evaluation criteria

- Code quality (should follow as closely as possible the clean code standard)
- SQL Query formatting
- Task accuracy


#### SQLite file Tables

##### Course

| Column | Type |
| --- | --- |
| id | bigint |
| title | varchar(100) |
| courseType_id | bigint |

##### CourseType

| Column | Type |
| --- | --- |
| id | bigint |
| name | varchar(50) |
