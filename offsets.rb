def offsets(c)
  c = c.split("").map(&:to_i)
  s = c[0]
  for i in 1...c.length - 1
    s += c[i + 1] - c[i]
  end
  s
end
