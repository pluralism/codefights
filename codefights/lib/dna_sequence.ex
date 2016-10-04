defmodule DnaSequence do
  def dnaSequence(s) do
    String.codepoints(s)
    |> Enum.reduce([%{[0, 0, 0] => 1}, %{}, 0], fn(x, acc) ->
      [d, h, sum] = acc
      h = Map.update(h, x, 1, &(&1 + 1))
      r = [Map.get(h, "A", 0) - Map.get(h, "C", 0),
           Map.get(h, "C", 0) - Map.get(h, "G", 0),
           Map.get(h, "G", 0) - Map.get(h, "T", 0)]
      [Map.update(d, r, 1, &(&1 + 1)), h, sum + Map.get(d, r, 0)]
    end)
    |> List.last
  end
end
