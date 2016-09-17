defmodule BlinyTest do
  use ExUnit.Case
  doctest Bliny

  test "Codefights tests" do
    assert Bliny.bliny [2, 1, 3]
    refute Bliny.bliny [3, 1, 2]
    refute Bliny.bliny [5, 3, 2, 4, 1]
    assert Bliny.bliny [5, 4, 7, 6, 3, 8, 2, 9, 10, 1]
    refute Bliny.bliny [1, 10, 9, 11, 12, 8, 13, 7, 6, 14, 4, 3, 5, 2]
    assert Bliny.bliny [1, 3, 2, 5, 6, 8, 7, 10, 9, 11, 13, 12, 4]
  end
end
