defmodule CodefightsTest do
  use ExUnit.Case
  doctest Codefights

  # The test files are Elixir script files(.exs).
  # It is convenient because we don't need to compile
  # test files before running them

  test "the truth" do
    assert 1 + 1 == 2
  end
end
