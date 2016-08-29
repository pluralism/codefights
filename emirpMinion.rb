require 'prime'
def emirpMinion(n)
  t = n.to_s
  s = 0

  0.upto(t.length - 1) { |i|
    0.upto(i) { |j|
      p = t[j..i]
      s += p.to_i if p.to_i.prime? and p.reverse.to_i.prime?
    }
  }
  s == 0 ? -1 : s
end
