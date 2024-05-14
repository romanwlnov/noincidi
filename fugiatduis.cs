// Assuming 'num' is already defined and holds the identifier for the state to load.
// This line loads the state associated with the given 'num' from a example-specific directory.
var state = StateStorage.Load($"example/{num}");

// Check if the state was successfully loaded before proceeding.
if (state != null)
{
    // The state is available, and you can now perform operations on it.
    // ... (additional logic can be placed here)
}
else
{
    // Handle the case where the state could not be loaded.
    // This could involve logging an error, attempting to load a default state, etc.
    // ... (error handling logic can be placed here)
}
