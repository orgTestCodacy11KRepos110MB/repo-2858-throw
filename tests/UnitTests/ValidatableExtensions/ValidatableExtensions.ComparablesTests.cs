namespace Throw.UnitTests.ValidatableExtensions;

[TestClass]
public class ComparablesTests
{
    [TestMethod]
    public void ThrowIfGreaterThan_WhenValueIsGreaterThan_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfGreaterThan(4);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be greater than 4. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfGreaterThan_WhenValueIsNotGreaterThan_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfGreaterThan(6);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThan_WhenValueEquals_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfGreaterThan(5);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_WhenValueIsGreaterThan_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfGreaterThanOrEqualTo(4);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be greater than or equal to 4. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_WhenValueIsNotGreaterThan_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfGreaterThanOrEqualTo(6);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfGreaterThanOrEqualTo_WhenValueEquals_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfGreaterThanOrEqualTo(5);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be greater than or equal to 5. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfLessThan_WhenValueIsLessThan_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfLessThan(6);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be less than 6. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfLessThan_WhenValueIsNotLessThan_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfLessThan(4);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThan_WhenValueEquals_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfLessThan(5);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_WhenValueIsLessThan_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfLessThanOrEqualTo(6);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be less than or equal to 6. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_WhenValueIsNotLessThan_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfLessThanOrEqualTo(4);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfLessThanOrEqualTo_WhenValueEquals_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfLessThanOrEqualTo(5);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be less than or equal to 5. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfPositive_WhenPositive_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfPositive();

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be greater than 0. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfPositive_WhenNegative_ShouldNotThrow()
    {
        // Arrange
        int value = -5;

        // Act
        Action action = () => value.Throw().IfPositive();

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfPositive_WhenZero_ShouldNotThrow()
    {
        // Arrange
        int value = 0;

        // Act
        Action action = () => value.Throw().IfPositive();

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfPositiveOrZero_WhenPositive_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfPositiveOrZero();

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be greater than or equal to 0. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfPositiveOrZero_WhenNegative_ShouldNotThrow()
    {
        // Arrange
        int value = -5;

        // Act
        Action action = () => value.Throw().IfPositiveOrZero();

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfPositiveOrZero_WhenZero_ShouldThrow()
    {
        // Arrange
        int value = 0;

        // Act
        Action action = () => value.Throw().IfPositiveOrZero();

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be greater than or equal to 0. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfNegative_WhenNegative_ShouldThrow()
    {
        // Arrange
        int value = -5;

        // Act
        Action action = () => value.Throw().IfNegative();

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be less than 0. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfNegative_WhenPositive_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfNegative();

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegative_WhenZero_ShouldNotThrow()
    {
        // Arrange
        int value = 0;

        // Act
        Action action = () => value.Throw().IfNegative();

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_WhenNegative_ShouldThrow()
    {
        // Arrange
        int value = -5;

        // Act
        Action action = () => value.Throw().IfNegativeOrZero();

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be less than or equal to 0. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_WhenPositive_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfNegativeOrZero();

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfNegativeOrZero_WhenZero_ShouldThrow()
    {
        // Arrange
        int value = 0;

        // Act
        Action action = () => value.Throw().IfNegativeOrZero();

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should not be less than or equal to 0. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfOutOfRange_WhenOutOfRange_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfOutOfRange(0, 4);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage($"Value should be between 0 and 4. (Parameter '{nameof(value)}')\nActual value was {value}.");
    }

    [TestMethod]
    public void ThrowIfOutOfRange_WhenInRange_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfOutOfRange(4, 6);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfOutOfRange_WhenEqualsLowerBound_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfOutOfRange(5, 6);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfOutOfRange_WhenEqualsUpperBound_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfOutOfRange(4, 5);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfInRange_WhenOutOfRange_ShouldNotThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfInRange(0, 4);

        // Assert
        action.Should().NotThrow();
    }

    [TestMethod]
    public void ThrowIfInRange_WhenInRange_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfInRange(4, 6);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage("Value should not be between 4 and 6. (Parameter 'value')\nActual value was 5.");
    }

    [TestMethod]
    public void ThrowIfInRange_WhenEqualsLowerBound_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfInRange(5, 6);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage("Value should not be between 5 and 6. (Parameter 'value')\nActual value was 5.");
    }

    [TestMethod]
    public void ThrowIfInRange_WhenEqualsUpperBound_ShouldThrow()
    {
        // Arrange
        int value = 5;

        // Act
        Action action = () => value.Throw().IfInRange(4, 5);

        // Assert
        action.Should()
            .ThrowExactly<ArgumentOutOfRangeException>()
            .WithMessage("Value should not be between 4 and 5. (Parameter 'value')\nActual value was 5.");
    }
}
