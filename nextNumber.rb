def nextNumber n
  b = a(n)
  n += 1
  n += 1 while a(n) != b
  n
end

def a s
  s.to_s(2).tr("0", "").length
end
