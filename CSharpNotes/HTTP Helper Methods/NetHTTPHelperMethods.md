# .NET HTTP Helper Methods Cheat Sheet

Quick reference for all HTTP helper methods available in ASP.NET Core `ControllerBase` class.

## 2xx Success Responses

### 200 OK

```csharp
Ok()                           // Empty 200 response
Ok(data)                       // 200 with content
Content("text")                // 200 with plain text
Content("html", "text/html")   // 200 with specific content type
Json(data)                     // 200 with JSON content
File(bytes, "application/pdf") // 200 with file download
PhysicalFile(path, contentType) // 200 with file from disk
```

### 201 Created

```csharp
Created("/api/users/123", user)                           // 201 with location
CreatedAtAction("GetUser", new { id = 123 }, user)        // 201 pointing to action
CreatedAtRoute("GetUserRoute", new { id = 123 }, user)    // 201 pointing to route
```

### 202 Accepted

```csharp
Accepted()                                    // Empty 202
Accepted("/api/status/123")                   // 202 with status location
Accepted("/api/status/123", statusData)       // 202 with location and content
AcceptedAtAction("GetStatus", statusData)     // 202 pointing to action
AcceptedAtRoute("StatusRoute", statusData)    // 202 pointing to route
```

### 204 No Content

```csharp
NoContent()  // 204 response (common for DELETE operations)
```

## 3xx Redirection Responses

### 301 Moved Permanently

```csharp
RedirectPermanent("https://newsite.com")
RedirectToActionPermanent("NewAction")
RedirectToRoutePermanent("NewRoute")
LocalRedirectPermanent("/new-path")
```

### 302 Found (Temporary Redirect)

```csharp
Redirect("https://example.com")
RedirectToAction("Index")
RedirectToAction("Details", new { id = 123 })
RedirectToAction("Index", "Home")
RedirectToRoute("UserProfile")
LocalRedirect("/dashboard")
```

### 307 Temporary Redirect (Preserves HTTP Method)

```csharp
RedirectPreserveMethod("https://api.example.com/v2")
RedirectToActionPreserveMethod("ProcessData")
RedirectToRoutePreserveMethod("ApiRoute")
LocalRedirectPreserveMethod("/api/v2")
```

### 308 Permanent Redirect (Preserves HTTP Method)

```csharp
RedirectPermanentPreserveMethod("https://api.example.com/v2")
RedirectToActionPermanentPreserveMethod("NewProcessData")
RedirectToRoutePermanentPreserveMethod("NewApiRoute")
LocalRedirectPermanentPreserveMethod("/api/v2")
```

## 4xx Client Error Responses

### 400 Bad Request

```csharp
BadRequest()                    // Empty 400
BadRequest("Invalid input")     // 400 with message
BadRequest(ModelState)          // 400 with validation errors
Problem("Error details", statusCode: 400)  // Problem Details format
```

### 401 Unauthorized

```csharp
Unauthorized()          // Empty 401
Challenge()             // Triggers authentication challenge
Challenge("Bearer")     // Challenge for specific scheme
```

### 403 Forbidden

```csharp
Forbid()               // Empty 403
Forbid("Bearer")       // 403 for specific auth scheme
```

### 404 Not Found

```csharp
NotFound()                        // Empty 404
NotFound("User not found")        // 404 with message
NotFound(new { error = "..." })   // 404 with object
```

### 409 Conflict

```csharp
Conflict()                           // Empty 409
Conflict("Resource already exists")  // 409 with message
Conflict(ModelState)                 // 409 with validation errors
```

### 422 Unprocessable Entity

```csharp
UnprocessableEntity()              // Empty 422
UnprocessableEntity("Invalid data") // 422 with message
UnprocessableEntity(ModelState)     // 422 with validation errors
```

## 5xx Server Error Responses

### 500 Internal Server Error

```csharp
Problem()                                    // Default 500 Problem Details
Problem("Something went wrong")              // 500 with custom message
StatusCode(500)                             // Generic 500
StatusCode(500, "Internal server error")    // 500 with message
```

## Generic Status Code Methods

```csharp
StatusCode(418)                    // Any status code
StatusCode(418, "I'm a teapot")    // Any status code with message
StatusCode(418, responseObject)    // Any status code with object
```

## Problem Details (RFC 7807)

```csharp
Problem()                                           // Default problem
Problem("Error occurred")                           // With detail
Problem("Error", "/api/users/123", 400)            // With instance and status
Problem("Error", "/api/users/123", 400, "Bad Request")  // With title
ValidationProblem()                                 // For validation errors
ValidationProblem(ModelState)                       // With model state errors
```

## Common Usage Patterns

### CRUD Operations

```csharp
// GET
public IActionResult GetUser(int id)
{
    var user = _service.GetUser(id);
    return user == null ? NotFound() : Ok(user);
}

// POST
public IActionResult CreateUser(User user)
{
    if (!ModelState.IsValid)
        return BadRequest(ModelState);

    var created = _service.CreateUser(user);
    return CreatedAtAction(nameof(GetUser), new { id = created.Id }, created);
}

// PUT
public IActionResult UpdateUser(int id, User user)
{
    if (!ModelState.IsValid)
        return BadRequest(ModelState);

    var exists = _service.UserExists(id);
    if (!exists)
        return NotFound();

    _service.UpdateUser(id, user);
    return NoContent();
}

// DELETE
public IActionResult DeleteUser(int id)
{
    var exists = _service.UserExists(id);
    if (!exists)
        return NotFound();

    _service.DeleteUser(id);
    return NoContent();
}
```

### Error Handling

```csharp
try
{
    var result = _service.ProcessData(data);
    return Ok(result);
}
catch (ValidationException ex)
{
    return BadRequest(ex.Message);
}
catch (NotFoundException ex)
{
    return NotFound(ex.Message);
}
catch (ConflictException ex)
{
    return Conflict(ex.Message);
}
catch (Exception ex)
{
    return Problem("An unexpected error occurred");
}
```

### Async Operations

```csharp
public async Task<IActionResult> ProcessLongRunningTask(TaskRequest request)
{
    var taskId = await _service.StartProcessingAsync(request);
    return AcceptedAtAction("GetTaskStatus", new { id = taskId });
}
```

## Quick Reference by HTTP Status Code

| Status | Method                             | Usage                                |
| ------ | ---------------------------------- | ------------------------------------ |
| 200    | `Ok()`, `Ok(data)`                 | Success with/without data            |
| 201    | `Created()`, `CreatedAtAction()`   | Resource created                     |
| 202    | `Accepted()`, `AcceptedAtAction()` | Request accepted for processing      |
| 204    | `NoContent()`                      | Success with no content (DELETE/PUT) |
| 301    | `RedirectPermanent()`              | Permanent redirect                   |
| 302    | `Redirect()`, `RedirectToAction()` | Temporary redirect                   |
| 400    | `BadRequest()`                     | Client error/validation failure      |
| 401    | `Unauthorized()`, `Challenge()`    | Authentication required              |
| 403    | `Forbid()`                         | Access denied                        |
| 404    | `NotFound()`                       | Resource not found                   |
| 409    | `Conflict()`                       | Resource conflict                    |
| 422    | `UnprocessableEntity()`            | Validation error                     |
| 500    | `Problem()`, `StatusCode(500)`     | Server error                         |
